namespace SerialCommnunication_CSharp
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.messageTextBox1 = new System.Windows.Forms.TextBox();
            this.writeButton1 = new System.Windows.Forms.Button();
            this.logTextBox1 = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.openButton1 = new System.Windows.Forms.Button();
            this.portselectComboBox1 = new System.Windows.Forms.ComboBox();
            this.bauRateComboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bauRateComboBox2 = new System.Windows.Forms.ComboBox();
            this.portselectComboBox2 = new System.Windows.Forms.ComboBox();
            this.openButton2 = new System.Windows.Forms.Button();
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.logTextBox2 = new System.Windows.Forms.TextBox();
            this.messageTextBox2 = new System.Windows.Forms.TextBox();
            this.writeButton2 = new System.Windows.Forms.Button();
            this.useDTRcheckBox2 = new System.Windows.Forms.CheckBox();
            this.useDTRcheckBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "Serial Port:";
            // 
            // messageTextBox1
            // 
            this.messageTextBox1.Location = new System.Drawing.Point(12, 231);
            this.messageTextBox1.Name = "messageTextBox1";
            this.messageTextBox1.Size = new System.Drawing.Size(180, 19);
            this.messageTextBox1.TabIndex = 8;
            // 
            // writeButton1
            // 
            this.writeButton1.Enabled = false;
            this.writeButton1.Location = new System.Drawing.Point(198, 227);
            this.writeButton1.Name = "writeButton1";
            this.writeButton1.Size = new System.Drawing.Size(75, 23);
            this.writeButton1.TabIndex = 7;
            this.writeButton1.Text = "Write";
            this.writeButton1.UseVisualStyleBackColor = true;
            this.writeButton1.Click += new System.EventHandler(this.writeButton_Click);
            // 
            // logTextBox1
            // 
            this.logTextBox1.Location = new System.Drawing.Point(12, 64);
            this.logTextBox1.Multiline = true;
            this.logTextBox1.Name = "logTextBox1";
            this.logTextBox1.ReadOnly = true;
            this.logTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logTextBox1.Size = new System.Drawing.Size(260, 157);
            this.logTextBox1.TabIndex = 6;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // openButton1
            // 
            this.openButton1.Enabled = false;
            this.openButton1.Location = new System.Drawing.Point(198, 10);
            this.openButton1.Name = "openButton1";
            this.openButton1.Size = new System.Drawing.Size(75, 23);
            this.openButton1.TabIndex = 11;
            this.openButton1.Text = "Open";
            this.openButton1.UseVisualStyleBackColor = true;
            this.openButton1.Click += new System.EventHandler(this.openButton_Click);
            // 
            // portselectComboBox1
            // 
            this.portselectComboBox1.FormattingEnabled = true;
            this.portselectComboBox1.Location = new System.Drawing.Point(71, 12);
            this.portselectComboBox1.Name = "portselectComboBox1";
            this.portselectComboBox1.Size = new System.Drawing.Size(121, 20);
            this.portselectComboBox1.TabIndex = 10;
            // 
            // bauRateComboBox1
            // 
            this.bauRateComboBox1.FormattingEnabled = true;
            this.bauRateComboBox1.Items.AddRange(new object[] {
            "300",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "57600",
            "115200"});
            this.bauRateComboBox1.Location = new System.Drawing.Point(71, 38);
            this.bauRateComboBox1.Name = "bauRateComboBox1";
            this.bauRateComboBox1.Size = new System.Drawing.Size(121, 20);
            this.bauRateComboBox1.TabIndex = 28;
            this.bauRateComboBox1.Text = "9600";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 12);
            this.label4.TabIndex = 27;
            this.label4.Text = "BaudRate:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 30;
            this.label2.Text = "BaudRate:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 12);
            this.label3.TabIndex = 29;
            this.label3.Text = "Serial Port:";
            // 
            // bauRateComboBox2
            // 
            this.bauRateComboBox2.FormattingEnabled = true;
            this.bauRateComboBox2.Items.AddRange(new object[] {
            "300",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "57600",
            "115200"});
            this.bauRateComboBox2.Location = new System.Drawing.Point(367, 38);
            this.bauRateComboBox2.Name = "bauRateComboBox2";
            this.bauRateComboBox2.Size = new System.Drawing.Size(121, 20);
            this.bauRateComboBox2.TabIndex = 32;
            this.bauRateComboBox2.Text = "9600";
            // 
            // portselectComboBox2
            // 
            this.portselectComboBox2.FormattingEnabled = true;
            this.portselectComboBox2.Location = new System.Drawing.Point(367, 12);
            this.portselectComboBox2.Name = "portselectComboBox2";
            this.portselectComboBox2.Size = new System.Drawing.Size(121, 20);
            this.portselectComboBox2.TabIndex = 31;
            // 
            // openButton2
            // 
            this.openButton2.Enabled = false;
            this.openButton2.Location = new System.Drawing.Point(497, 10);
            this.openButton2.Name = "openButton2";
            this.openButton2.Size = new System.Drawing.Size(75, 23);
            this.openButton2.TabIndex = 33;
            this.openButton2.Text = "Open";
            this.openButton2.UseVisualStyleBackColor = true;
            this.openButton2.Click += new System.EventHandler(this.openButton2_Click);
            // 
            // serialPort2
            // 
            this.serialPort2.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort2_DataReceived);
            // 
            // logTextBox2
            // 
            this.logTextBox2.Location = new System.Drawing.Point(302, 64);
            this.logTextBox2.Multiline = true;
            this.logTextBox2.Name = "logTextBox2";
            this.logTextBox2.ReadOnly = true;
            this.logTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logTextBox2.Size = new System.Drawing.Size(260, 157);
            this.logTextBox2.TabIndex = 34;
            // 
            // messageTextBox2
            // 
            this.messageTextBox2.Location = new System.Drawing.Point(302, 231);
            this.messageTextBox2.Name = "messageTextBox2";
            this.messageTextBox2.Size = new System.Drawing.Size(180, 19);
            this.messageTextBox2.TabIndex = 35;
            // 
            // writeButton2
            // 
            this.writeButton2.Enabled = false;
            this.writeButton2.Location = new System.Drawing.Point(487, 231);
            this.writeButton2.Name = "writeButton2";
            this.writeButton2.Size = new System.Drawing.Size(75, 23);
            this.writeButton2.TabIndex = 36;
            this.writeButton2.Text = "Write";
            this.writeButton2.UseVisualStyleBackColor = true;
            this.writeButton2.Click += new System.EventHandler(this.writeButton2_Click);
            // 
            // useDTRcheckBox2
            // 
            this.useDTRcheckBox2.AutoSize = true;
            this.useDTRcheckBox2.Checked = true;
            this.useDTRcheckBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.useDTRcheckBox2.Location = new System.Drawing.Point(497, 42);
            this.useDTRcheckBox2.Name = "useDTRcheckBox2";
            this.useDTRcheckBox2.Size = new System.Drawing.Size(67, 16);
            this.useDTRcheckBox2.TabIndex = 37;
            this.useDTRcheckBox2.Text = "UseDTR";
            this.useDTRcheckBox2.UseVisualStyleBackColor = true;
            // 
            // useDTRcheckBox1
            // 
            this.useDTRcheckBox1.AutoSize = true;
            this.useDTRcheckBox1.Checked = true;
            this.useDTRcheckBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.useDTRcheckBox1.Location = new System.Drawing.Point(198, 41);
            this.useDTRcheckBox1.Name = "useDTRcheckBox1";
            this.useDTRcheckBox1.Size = new System.Drawing.Size(67, 16);
            this.useDTRcheckBox1.TabIndex = 38;
            this.useDTRcheckBox1.Text = "UseDTR";
            this.useDTRcheckBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 262);
            this.Controls.Add(this.useDTRcheckBox1);
            this.Controls.Add(this.useDTRcheckBox2);
            this.Controls.Add(this.writeButton2);
            this.Controls.Add(this.messageTextBox2);
            this.Controls.Add(this.logTextBox2);
            this.Controls.Add(this.openButton2);
            this.Controls.Add(this.bauRateComboBox2);
            this.Controls.Add(this.portselectComboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bauRateComboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.messageTextBox1);
            this.Controls.Add(this.writeButton1);
            this.Controls.Add(this.logTextBox1);
            this.Controls.Add(this.openButton1);
            this.Controls.Add(this.portselectComboBox1);
            this.Name = "Form1";
            this.Text = "SerialCommunication";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox messageTextBox1;
        private System.Windows.Forms.Button writeButton1;
        private System.Windows.Forms.TextBox logTextBox1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button openButton1;
        private System.Windows.Forms.ComboBox portselectComboBox1;
        private System.Windows.Forms.ComboBox bauRateComboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox bauRateComboBox2;
        private System.Windows.Forms.ComboBox portselectComboBox2;
        private System.Windows.Forms.Button openButton2;
        private System.IO.Ports.SerialPort serialPort2;
        private System.Windows.Forms.TextBox logTextBox2;
        private System.Windows.Forms.TextBox messageTextBox2;
        private System.Windows.Forms.Button writeButton2;
        private System.Windows.Forms.CheckBox useDTRcheckBox2;
        private System.Windows.Forms.CheckBox useDTRcheckBox1;
    }
}

