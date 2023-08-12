using Google.Apis.Auth.OAuth2;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Serial_Connect_using_Excel_Csharp
{
    public partial class Form1 : Form
    {
        private SheetsService sheetsService;
        public bool isConnect = false;
        public Form1()
        {
            InitializeComponent();
            sheetsService = GoogleSheetsAuthentication.GetService();
        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            this.Invoke(method: new Action(async () =>
            {
                // Reading data from Spreadsheet
                var spreadsheetId = "1mJaB-cHFzEjvJDtat8mvmrHq5ABqpsW4WR8ZNnRAyHE";
                var range = comboBoxReadalpha.Text + comboBoxReadnum.Text;

                var request = sheetsService.Spreadsheets.Values.Get(spreadsheetId, range);
                var response = await request.ExecuteAsync();

                IList<IList<object>> values = response.Values;

                if (values != null && values.Count > 0)
                {
                    textBoxRead.Text = values[0][0].ToString();
                }
                else
                {
                    textBoxRead.Text = "No Data Found!";
                }

            }));
        }

        private void buttonWrite_Click(object sender, EventArgs e)
        {
            this.Invoke(method: new Action(async () =>
            {
                var rowData = new List<object>
                {
                    textBoxWrite.Text
                };

                // Writing data to Google Sheet
                var spreadsheetId = "1mJaB-cHFzEjvJDtat8mvmrHq5ABqpsW4WR8ZNnRAyHE";
                var range = comboBoxWritealpha.Text + comboBoxWritenum.Text;
                var valueRange = new ValueRange
                {
                    Values = new List<IList<object>> { rowData }
                };

                var updateRequest = sheetsService.Spreadsheets.Values.Update(valueRange, spreadsheetId, range);

                updateRequest.ValueInputOption =
                    SpreadsheetsResource.ValuesResource.UpdateRequest.ValueInputOptionEnum.RAW;

                var updateResponse = await updateRequest.ExecuteAsync();
            }));
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            isConnect = !isConnect;

            if (isConnect)
            {
                serialPort1.PortName = comboBoxCOM.Text;
                serialPort1.BaudRate = int.Parse(comboBoxBaud.Text);
                serialPort1.Open();
                timer1.Enabled = true;
                timer1.Interval = 1000;

                buttonConnect.Text = "Disconnect";
            }
            else
            {
                serialPort1.Close();
                timer1.Stop();
                buttonConnect.Text = "Connect";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Invoke(method: new Action(async () =>
            {
                // Reading data from Spreadsheet
                var spreadsheetId = "1mJaB-cHFzEjvJDtat8mvmrHq5ABqpsW4WR8ZNnRAyHE";
                var range = "Sheet1!B1";

                var request = sheetsService.Spreadsheets.Values.Get(spreadsheetId, range);
                var response = await request.ExecuteAsync();

                IList<IList<object>> values = response.Values;

                if (values != null && values.Count > 0)
                {
                    textBoxPort.Text = values[0][0].ToString();
                }
                else
                {
                    ;
                }

            }));

            serialPort1.Write(textBoxPort.Text);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
            serialPort1.Close();
        }
    }

    public class GoogleSheetsAuthentication
    {
        static string[] Scopes = { SheetsService.Scope.Spreadsheets };
        static string ApplicationName = "ABC";
        static string ClientSecretFilePath;

        static GoogleSheetsAuthentication()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            ClientSecretFilePath = Path.Combine(currentDirectory, "token.json");
        }

        public static SheetsService GetService()
        {
            UserCredential credential;

            using (var stream = new FileStream(ClientSecretFilePath, FileMode.Open, FileAccess.Read))
            {
                string credPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                credPath = Path.Combine(credPath, ".credentials/sheets-dotnet-quickstart.json");

                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets, Scopes, "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
                Console.WriteLine("Credential file saved to: " + credPath);
            }

            return new SheetsService(new Google.Apis.Services.BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });
        }
    }
}
