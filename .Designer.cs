namespace Serial_Connect_using_Excel_Csharp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.comboBoxBaud = new System.Windows.Forms.ComboBox();
            this.comboBoxCOM = new System.Windows.Forms.ComboBox();
            this.labelWrite = new System.Windows.Forms.Label();
            this.labelRead = new System.Windows.Forms.Label();
            this.buttonWrite = new System.Windows.Forms.Button();
            this.comboBoxWritenum = new System.Windows.Forms.ComboBox();
            this.comboBoxWritealpha = new System.Windows.Forms.ComboBox();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.textBoxWrite = new System.Windows.Forms.TextBox();
            this.buttonRead = new System.Windows.Forms.Button();
            this.comboBoxReadnum = new System.Windows.Forms.ComboBox();
            this.comboBoxReadalpha = new System.Windows.Forms.ComboBox();
            this.textBoxRead = new System.Windows.Forms.TextBox();
            this.labelPort = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // buttonConnect
            // 
            this.buttonConnect.BackColor = System.Drawing.Color.Black;
            this.buttonConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConnect.ForeColor = System.Drawing.Color.White;
            this.buttonConnect.Location = new System.Drawing.Point(571, 170);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(131, 33);
            this.buttonConnect.TabIndex = 26;
            this.buttonConnect.Text = "CONNECT";
            this.buttonConnect.UseVisualStyleBackColor = false;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // comboBoxBaud
            // 
            this.comboBoxBaud.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBaud.FormattingEnabled = true;
            this.comboBoxBaud.Items.AddRange(new object[] {
            "12800",
            "9600",
            "4800",
            "2400",
            "1200",
            "600",
            "300",
            "150"});
            this.comboBoxBaud.Location = new System.Drawing.Point(239, 176);
            this.comboBoxBaud.Name = "comboBoxBaud";
            this.comboBoxBaud.Size = new System.Drawing.Size(121, 24);
            this.comboBoxBaud.TabIndex = 24;
            this.comboBoxBaud.Text = "9600";
            // 
            // comboBoxCOM
            // 
            this.comboBoxCOM.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCOM.FormattingEnabled = true;
            this.comboBoxCOM.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10"});
            this.comboBoxCOM.Location = new System.Drawing.Point(86, 176);
            this.comboBoxCOM.Name = "comboBoxCOM";
            this.comboBoxCOM.Size = new System.Drawing.Size(121, 24);
            this.comboBoxCOM.TabIndex = 25;
            this.comboBoxCOM.Text = "COM3";
            // 
            // labelWrite
            // 
            this.labelWrite.AutoSize = true;
            this.labelWrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWrite.Location = new System.Drawing.Point(15, 101);
            this.labelWrite.Name = "labelWrite";
            this.labelWrite.Size = new System.Drawing.Size(49, 20);
            this.labelWrite.TabIndex = 23;
            this.labelWrite.Text = "Write";
            // 
            // labelRead
            // 
            this.labelRead.AutoSize = true;
            this.labelRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRead.Location = new System.Drawing.Point(15, 26);
            this.labelRead.Name = "labelRead";
            this.labelRead.Size = new System.Drawing.Size(48, 20);
            this.labelRead.TabIndex = 22;
            this.labelRead.Text = "Read";
            // 
            // buttonWrite
            // 
            this.buttonWrite.BackColor = System.Drawing.Color.Black;
            this.buttonWrite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonWrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWrite.ForeColor = System.Drawing.Color.White;
            this.buttonWrite.Location = new System.Drawing.Point(580, 94);
            this.buttonWrite.Name = "buttonWrite";
            this.buttonWrite.Size = new System.Drawing.Size(109, 34);
            this.buttonWrite.TabIndex = 21;
            this.buttonWrite.Text = "WRITE";
            this.buttonWrite.UseVisualStyleBackColor = false;
            this.buttonWrite.Click += new System.EventHandler(this.buttonWrite_Click);
            // 
            // comboBoxWritenum
            // 
            this.comboBoxWritenum.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxWritenum.FormattingEnabled = true;
            this.comboBoxWritenum.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.comboBoxWritenum.Location = new System.Drawing.Point(239, 99);
            this.comboBoxWritenum.Name = "comboBoxWritenum";
            this.comboBoxWritenum.Size = new System.Drawing.Size(121, 24);
            this.comboBoxWritenum.TabIndex = 20;
            this.comboBoxWritenum.Text = "1";
            // 
            // comboBoxWritealpha
            // 
            this.comboBoxWritealpha.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxWritealpha.FormattingEnabled = true;
            this.comboBoxWritealpha.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.comboBoxWritealpha.Location = new System.Drawing.Point(86, 99);
            this.comboBoxWritealpha.Name = "comboBoxWritealpha";
            this.comboBoxWritealpha.Size = new System.Drawing.Size(121, 24);
            this.comboBoxWritealpha.TabIndex = 19;
            this.comboBoxWritealpha.Text = "B";
            // 
            // textBoxPort
            // 
            this.textBoxPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPort.Location = new System.Drawing.Point(389, 176);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(148, 22);
            this.textBoxPort.TabIndex = 17;
            this.textBoxPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxWrite
            // 
            this.textBoxWrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxWrite.Location = new System.Drawing.Point(389, 101);
            this.textBoxWrite.Name = "textBoxWrite";
            this.textBoxWrite.Size = new System.Drawing.Size(148, 22);
            this.textBoxWrite.TabIndex = 18;
            this.textBoxWrite.Text = "L";
            this.textBoxWrite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonRead
            // 
            this.buttonRead.BackColor = System.Drawing.Color.Black;
            this.buttonRead.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRead.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonRead.FlatAppearance.BorderSize = 5;
            this.buttonRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRead.ForeColor = System.Drawing.Color.White;
            this.buttonRead.Location = new System.Drawing.Point(580, 20);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(109, 32);
            this.buttonRead.TabIndex = 16;
            this.buttonRead.Text = "READ";
            this.buttonRead.UseVisualStyleBackColor = false;
            this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click);
            // 
            // comboBoxReadnum
            // 
            this.comboBoxReadnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxReadnum.FormattingEnabled = true;
            this.comboBoxReadnum.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.comboBoxReadnum.Location = new System.Drawing.Point(239, 24);
            this.comboBoxReadnum.Name = "comboBoxReadnum";
            this.comboBoxReadnum.Size = new System.Drawing.Size(121, 24);
            this.comboBoxReadnum.TabIndex = 15;
            this.comboBoxReadnum.Text = "1";
            // 
            // comboBoxReadalpha
            // 
            this.comboBoxReadalpha.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxReadalpha.FormattingEnabled = true;
            this.comboBoxReadalpha.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.comboBoxReadalpha.Location = new System.Drawing.Point(86, 24);
            this.comboBoxReadalpha.Name = "comboBoxReadalpha";
            this.comboBoxReadalpha.Size = new System.Drawing.Size(121, 24);
            this.comboBoxReadalpha.TabIndex = 14;
            this.comboBoxReadalpha.Text = "A";
            // 
            // textBoxRead
            // 
            this.textBoxRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRead.Location = new System.Drawing.Point(389, 24);
            this.textBoxRead.Name = "textBoxRead";
            this.textBoxRead.Size = new System.Drawing.Size(148, 22);
            this.textBoxRead.TabIndex = 13;
            this.textBoxRead.Text = "Waiting....";
            this.textBoxRead.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPort.Location = new System.Drawing.Point(15, 176);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(40, 20);
            this.labelPort.TabIndex = 27;
            this.labelPort.Text = "Port";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(729, 231);
            this.Controls.Add(this.labelPort);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.comboBoxBaud);
            this.Controls.Add(this.comboBoxCOM);
            this.Controls.Add(this.labelWrite);
            this.Controls.Add(this.labelRead);
            this.Controls.Add(this.buttonWrite);
            this.Controls.Add(this.comboBoxWritenum);
            this.Controls.Add(this.comboBoxWritealpha);
            this.Controls.Add(this.textBoxPort);
            this.Controls.Add(this.textBoxWrite);
            this.Controls.Add(this.buttonRead);
            this.Controls.Add(this.comboBoxReadnum);
            this.Controls.Add(this.comboBoxReadalpha);
            this.Controls.Add(this.textBoxRead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Serial Port Interface";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.ComboBox comboBoxBaud;
        private System.Windows.Forms.ComboBox comboBoxCOM;
        private System.Windows.Forms.Label labelWrite;
        private System.Windows.Forms.Label labelRead;
        private System.Windows.Forms.Button buttonWrite;
        private System.Windows.Forms.ComboBox comboBoxWritenum;
        private System.Windows.Forms.ComboBox comboBoxWritealpha;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.TextBox textBoxWrite;
        private System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.ComboBox comboBoxReadnum;
        private System.Windows.Forms.ComboBox comboBoxReadalpha;
        private System.Windows.Forms.TextBox textBoxRead;
        private System.Windows.Forms.Label labelPort;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
    }
}

