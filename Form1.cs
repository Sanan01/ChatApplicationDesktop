using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;


namespace ChatAppAssignment1
{
    public partial class Form1 : Form
    {
        private TcpClient client;
        public StreamReader STR;
        public StreamWriter STW;
        public string receive;
        public string send;
        public Form1()
        {
            InitializeComponent();
            IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress ip in localIP)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    sIPtextBox.Text = ip.ToString();
                }
            }
        }

        private void startbutton_Click_1(object sender, EventArgs e)
        {
            TcpListener listener = new TcpListener(IPAddress.Any, int.Parse(sPorttextBox.Text));
            listener.Start();
            client = listener.AcceptTcpClient();
            STR = new StreamReader(client.GetStream());
            STW = new StreamWriter(client.GetStream())
            {
                AutoFlush = true
            };
            backgroundWorker3.RunWorkerAsync();
            backgroundWorker4.WorkerSupportsCancellation = true;
        }

        private void connectbutton_Click_1(object sender, EventArgs e)
        {
            client = new TcpClient();
            IPEndPoint IpEnd = new IPEndPoint(IPAddress.Parse(cIPtextBox.Text), int.Parse(cPorttextBox.Text));
            try
            {
                client.Connect(IpEnd);
                ctextBox.AppendText("Connected to server\n");
                STW = new StreamWriter(client.GetStream());
                STR = new StreamReader(client.GetStream());
                STW.AutoFlush = true;
                backgroundWorker3.RunWorkerAsync();
                backgroundWorker4.WorkerSupportsCancellation = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void backgroundWorker3_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            while (client.Connected)
            {
                try
                {
                    receive = STR.ReadLine();
                    this.ctextBox.Invoke(new MethodInvoker(delegate ()
                    {
                        ctextBox.AppendText("Server: " + receive + '\n');
                    }
                        ));
                    receive = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void backgroundWorker4_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            if (client.Connected)
            {
                STW.WriteLine(send);
                this.ctextBox.Invoke(new MethodInvoker(delegate ()
                {
                    ctextBox.AppendText("Client: " + send + '\n');
                }
                        ));
            }
            else
            {
                MessageBox.Show("Sending failed");
            }
            backgroundWorker4.CancelAsync();
        }

        private void sendbutton_Click(object sender, EventArgs e)
        {
            if (sendtextBox.Text != "")
            {
                send = sendtextBox.Text;
                backgroundWorker4.RunWorkerAsync();
            }
            sendtextBox.Text = "";
        }
    }

}