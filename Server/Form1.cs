using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartServer();
        }

        void StartServer()
        {
            var ip = Dns.GetHostEntry(tbHost.Text);
            var ad = ip.AddressList[0];
            var ep = new IPEndPoint(ad, int.Parse(tbPort.Text));
            Socket listener = new Socket(ad.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            listener.Bind(ep);
            listener.Listen(20);
            listBox1.Items.Add("������� " + ep);
            Socket handler;
            while (true) 
            {
                byte[] bytes = new byte[1024];
                handler = listener.Accept();
                string data = null;
                int count = handler.Receive(bytes);
                var st = Encoding.UTF8.GetString(bytes, 0, count);

            }
        }
    }
}