using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Collections.Generic;

namespace chatSunucu
{
    public partial class Form1 : Form
    {
        private TcpListener listener;
        private List<TcpClient> clients = new List<TcpClient>();
        private bool isRunning = false;

        public Form1()
        {
            InitializeComponent();
            listBox1.Items.Add("Form yüklendi.");
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            isRunning = true;
            listener = new TcpListener(IPAddress.Any, 5000);
            listener.Start();
            Thread acceptThread = new Thread(AcceptClients);
            acceptThread.IsBackground = true;
            acceptThread.Start();

            // Sunucu IP ve portunu ekrana yazdýr
            string localIP = GetLocalIPAddress();
            int port = ((IPEndPoint)listener.LocalEndpoint).Port;
            listBox1.Items.Add($"Sunucu baþlatýldý... IP: {localIP}, Port: {port}");
        }

        private void AcceptClients()
        {
            while (isRunning)
            {
                TcpClient client = listener.AcceptTcpClient();
                clients.Add(client);
                Thread clientThread = new Thread(() => HandleClient(client));
                clientThread.IsBackground = true;
                clientThread.Start();
            }
        }

        private void HandleClient(TcpClient client)
        {
            NetworkStream stream = client.GetStream();
            byte[] buffer = new byte[1024];
            int byteCount;

            while ((byteCount = stream.Read(buffer, 0, buffer.Length)) > 0)
            {
                string message = Encoding.UTF8.GetString(buffer, 0, byteCount);
                BroadcastMessage(message, client);
                Invoke(new Action(() => listBox1.Items.Add("Mesaj: " + message)));
            }
            clients.Remove(client);
            client.Close();
        }

        private void BroadcastMessage(string message, TcpClient sender)
        {
            byte[] buffer = Encoding.UTF8.GetBytes(message);
            foreach (var client in clients)
            {
                if (client != sender)
                {
                    try
                    {
                        client.GetStream().Write(buffer, 0, buffer.Length);
                    }
                    catch { }
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            isRunning = false;
            listener?.Stop();
            foreach (var client in clients)
                client.Close();
        }

        private string GetLocalIPAddress()
        {
            foreach (var ip in Dns.GetHostEntry(Dns.GetHostName()).AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                    return ip.ToString();
            }
            return "IP bulunamadý";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
