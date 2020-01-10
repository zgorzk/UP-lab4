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
using System.Threading;
using System.IO;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        string filename;
        static SerialPort _serialPort;
        Thread read;
        public void sendMessage(string message)
        {
            if (_serialPort != null)
            {
                _serialPort.Write(message + Environment.NewLine);
            }
            else
            {
                RTBLogBox.Text += "nie wykryto podłaczonego modemu\n";
            }
        }
        public void Read()
        {
            while (_serialPort.IsOpen)
            {
                try
                {
                    string message = _serialPort.ReadExisting();
                    if (message.Length > 0)
                    {
                        Console.Write(message);
                    }
                }
                catch (TimeoutException) { }
            }
        }


        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (_serialPort != null)
            {
                if (_serialPort.IsOpen) _serialPort.Close();
            }
            _serialPort = new SerialPort(textBox1.Text);

            // Allow the user to set the appropriate properties.
            _serialPort.BaudRate = 9600;
            _serialPort.DtrEnable = true;
            _serialPort.Handshake = Handshake.RequestToSendXOnXOff;

            // Set the read/write timeouts
            _serialPort.ReadTimeout = 500;
            _serialPort.WriteTimeout = 500;

            if (_serialPort != null)
            {
                _serialPort.Open();
            }
            RTBLogBox.Text += ("connected to port " + textBox1.Text + "\n");
            this.sendMessage("ATZ"); // resetuje
            Thread.Sleep(500);
            this.sendMessage("ATE1"); // Echo commands to computer


            read = new Thread(Read);
            read.Start();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Bconnect.Text = "CONNECT: " + textBox1.Text;
        }

        private void Bdisconnect_Click(object sender, EventArgs e)
        {
            if (_serialPort != null)
            {
                RTBLogBox.Text += "rozłaczono\n";
                _serialPort.Close();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (_serialPort != null)
                {
                    this.sendMessage(textBox2.Text);
                    RTBLogBox.Text += "wysłano wiadomośc" + textBox2.Text + "\n";
                }
                Thread.Sleep(500);
            }

        }

        private void BsendFile_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filename = openFileDialog.FileName;
            }
            FileStream fileStream = File.OpenRead(filename);
            BinaryReader binaryReader = new BinaryReader(fileStream);
            _serialPort.Write(binaryReader.ReadBytes((int)fileStream.Length), 0, (int)fileStream.Length);
        }

    }
}
