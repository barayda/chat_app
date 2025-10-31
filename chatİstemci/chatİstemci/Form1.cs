using System;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chatİstemci
{
    public partial class Form1 : Form
    {
        private TcpClient client;
        private NetworkStream stream;

        public Form1()
        {
            InitializeComponent();
        }

        private async void btnBaglan_Click(object sender, EventArgs e)
        {
            try
            {
                client = new TcpClient();
                await client.ConnectAsync(txtSunucuIP.Text, int.Parse(txtPort.Text));
                stream = client.GetStream();
                AppendText("Sunucuya bağlanıldı.");
                _ = Task.Run(ReceiveMessages);
            }
            catch (Exception ex)
            {
                AppendText("Bağlantı hatası: " + ex.Message);
            }
        }

        private async void btnGonder_Click(object sender, EventArgs e)
        {
            if (stream != null && stream.CanWrite)
            {
                string mesaj = txtMesaj.Text;
                byte[] data = Encoding.UTF8.GetBytes(mesaj);
                await stream.WriteAsync(data, 0, data.Length);
                AppendText("Siz: " + mesaj);
                txtMesaj.Clear();
            }
        }

        private async Task ReceiveMessages()
        {
            byte[] buffer = new byte[1024];
            while (client.Connected)
            {
                try
                {
                    int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
                    if (bytesRead > 0)
                    {
                        string gelenMesaj = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                        AppendText("Sunucu: " + gelenMesaj);
                    }
                }
                catch
                {
                    AppendText("Bağlantı kesildi.");
                    break;
                }
            }
        }

        private void AppendText(string text)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(AppendText), text);
            }
            else
            {
                txtChat.AppendText(text + Environment.NewLine);
            }
        }

        private void txtPort_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
