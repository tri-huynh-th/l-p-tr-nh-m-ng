using System;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Client
{
    public partial class ChatForm : Form
    {
        private string userName;
        private string severIp;
        private TcpClient client;
        private StreamReader reader;
        private StreamWriter writer;
        private Thread clientThread;

        public ChatForm()
        {
            InitializeComponent();
        }

        public ChatForm(string userName, string severIp)
        {
            InitializeComponent();

            this.userName = userName;
            this.severIp = severIp;

            userNamelabel.Text = userName;
            ipLabel.Text =  severIp;

            connectToServer();
        }

        private void connectToServer()
        {
            try
            {
                int port = 9000;
                client = new TcpClient(severIp, port);

                var stream = client.GetStream();
                reader = new StreamReader(stream, Encoding.UTF8);
                writer = new StreamWriter(stream, Encoding.UTF8) { AutoFlush = true };

                writer.WriteLine(userName);

                clientThread = new Thread(receiveMessages);
                clientThread.Start();

                appendMessage("Kết nối thành công đến server.");
            }
            catch (Exception ex)
            {
                appendMessage("Không thể kết nối đến server: " + ex.Message);
            }
        }

        private void receiveMessages()
        {
            while (client.Connected)
            {
                try
                {
                    var message = reader.ReadLine();
                    if (message != null)
                    {
                        appendMessage(message);
                    }
                    else
                    {
                        appendMessage("Server đã ngắt kết nối.");
                        break;
                    }
                }
                catch (Exception ex)
                {
                    appendMessage("Mất kết nối đến server: " + ex.Message);
                    break;
                }
            }
        }

        private void appendMessage(string message)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(appendMessage), message);
                return;
            }
            messageBox.AppendText(message + Environment.NewLine);
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            var message = sendBox.Text.Trim();
            if (!string.IsNullOrEmpty(message))
            {
                writer.WriteLine(message);
                appendMessage("Bạn: "+ message);
                sendBox.Clear();
            }
        }

        private void ChatForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (client != null && client.Connected)
            {
                client.Close();
            }
            if (clientThread != null && clientThread.IsAlive)
            {
                clientThread.Abort();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void sendBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
