using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

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
                portselectComboBox.Items.Add(portName);
            }
            if (portselectComboBox.Items.Count > 0)
            {
                portselectComboBox.SelectedIndex = 0;
                openButton.Enabled = true;
            }
        }
        /****************************************************************************/
        /*!
         * openButtonが押されると実行されます。
         * 接続の分岐をします。
         */
        private void openButton_Click(object sender, EventArgs e)
        {
            if (openButton.Text == "Open")
            {
                serialPortOpen();
                openButton.Text = "Close";
            }
            else
            {
                serialPortClose();
                openButton.Text = "Open";
            }
        }
        /****************************************************************************/
        /*!
         * 接続を開始します。
         */
        private void serialPortOpen()
        {
            string portName = portselectComboBox.SelectedItem.ToString();
            serialPort1.BaudRate = 9600;
            serialPort1.PortName = portName;
            serialPort1.Open();
            writeButton.Enabled = true;
        }
        /****************************************************************************/
        /*!
         * 接続を終了します。
         */
        private void serialPortClose()
        {
            serialPort1.Close();
            writeButton.Enabled = false;
        }
        /****************************************************************************/
        /*!
         * writeButtonが押されると実行されます。
         * serialPort1に送信します。
         */
        private void writeButton_Click(object sender, EventArgs e)
        {
            String text = messageTextBox.Text;
            serialPort1.Write(text);
            logTextBox.AppendText("Write : " + text + "\n");
            //Console.WriteLine(text);
            // messageTextBoxをクリア
            messageTextBox.Text = "";
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
                logTextBox.AppendText("Read : " + data + "\n");
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

    }
}
