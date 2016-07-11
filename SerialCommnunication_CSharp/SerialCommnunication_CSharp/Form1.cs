using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace SerialCommnunication_CSharp
{

    public partial class Form1 : Form
    {
        // スレッド間処理のために用意
        private delegate void Delegate_write(string data);

        public Form1()
        {
            InitializeComponent();
            setSerialComboBox();
        }
        /****************************************************************************/
        /*!
         * シリアルポートを選択するComboBoxを作ります。
         * 接続されているポートの名前を取得し、表示します。
         */
        private void setSerialComboBox()
        {
            foreach (var portName in SerialPort.GetPortNames())
            {
                portselectComboBox1.Items.Add(portName);
                portselectComboBox2.Items.Add(portName);
            }
            if (portselectComboBox1.Items.Count > 0)
            {
                portselectComboBox1.SelectedIndex = 0;
                portselectComboBox2.SelectedIndex = 0;
                openButton1.Enabled = true;
                openButton2.Enabled = true;
            }
        }
        /****************************************************************************/
        /*!
         * openButtonが押されると実行されます。
         * 接続の分岐をします。
         */
        private void openButton_Click(object sender, EventArgs e)
        {
            if (openButton1.Text == "Open")
            {
                serialPortOpen();
                openButton1.Text = "Close";
            }
            else
            {
                serialPortClose();
                openButton1.Text = "Open";
            }
        }
        /****************************************************************************/
        /*!
         * 接続を開始します。
         */
        private void serialPortOpen()
        {
            string portName = portselectComboBox1.SelectedItem.ToString();
            serialPort1.BaudRate = int.Parse(bauRateComboBox1.Text);//9600;
            serialPort1.PortName = portName;
            serialPort1.DtrEnable = useDTRcheckBox1.Enabled;
            serialPort1.Open();
            writeButton1.Enabled = true;
        }
        /****************************************************************************/
        /*!
         * 接続を終了します。
         */
        private void serialPortClose()
        {
            serialPort1.Close();
            writeButton1.Enabled = false;
        }
        /****************************************************************************/
        /*!
         * writeButtonが押されると実行されます。
         * serialPort1に送信します。
         */
        private void writeButton_Click(object sender, EventArgs e)
        {
            String text = messageTextBox1.Text;
            serialPort1.Write(text);
            logTextBox1.AppendText("Write : " + text + "\n");
            //Console.WriteLine(text);
            // messageTextBoxをクリア
            messageTextBox1.Text = "";
        }

        /****************************************************************************/
        /*!
         * serialPort1でデータを受信すると実行されます。
         * スレッドが異なるので、Invokeを使う。
         * http://kana-soft.com/tech/sample_0007_4.htm
         */
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // 受信したデータ
            string data = serialPort1.ReadLine();
            // 異なるスレッドのテキストボックスに書き込む
            Invoke(new Delegate_write(write), new Object[] { data });
        }

        /****************************************************************************/
        /*!
         * logTextBoxに受信内容を書き込みます。
         */
        private void write(string data)
        {
            if (data != null)
            {
                logTextBox1.AppendText("Read : " + data + "\n");
            }
        }

        /****************************************************************************/
        /*!
         * ウィンドウが閉じられる際に実行されます。
         */
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // シリアル通信していた場合は、閉じてから終了する
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
        }

        private void openButton2_Click(object sender, EventArgs e)
        {
            if (openButton2.Text == "Open")
            {
                serialPortOpen2();
                openButton2.Text = "Close";
            }
            else
            {
                serialPortClose2();
                openButton2.Text = "Open";
            }

        }

        private void serialPort2_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
           string data = serialPort2.ReadLine();
            // 異なるスレッドのテキストボックスに書き込む
            Invoke(new Delegate_write(write2), new Object[] { data });

        }
        private void serialPortOpen2()
        {
            string portName = portselectComboBox2.SelectedItem.ToString();
            serialPort2.BaudRate = int.Parse(bauRateComboBox2.Text);//9600;
            serialPort2.PortName = portName;
            serialPort2.DtrEnable = useDTRcheckBox2.Enabled;
            serialPort2.Open();
            writeButton2.Enabled = true;
        }
        private void serialPortClose2()
        {
            serialPort2.Close();
            writeButton2.Enabled = false;
        }
        private void write2(string data)
        {
            if (data != null)
            {
                logTextBox2.AppendText("Read : " + data + "\n");
            }
        }

        private void writeButton2_Click(object sender, EventArgs e)
        {
            String text = messageTextBox2.Text;
            serialPort2.Write(text);
            logTextBox2.AppendText("Write : " + text + "\n");
            //Console.WriteLine(text);
            // messageTextBoxをクリア
            messageTextBox2.Text = "";

        }
    }
}
