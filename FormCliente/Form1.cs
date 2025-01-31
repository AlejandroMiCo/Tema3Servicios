using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormCliente   // Titulo, icono,
                        // comprobar puerto 
{
    public partial class ClienteSuperChulo : Form
    {
        public string ipServer = IPAddress.Loopback.ToString();
        public int port = 16180;
        IPEndPoint ie;

        public ClienteSuperChulo()
        {
            InitializeComponent();
            ie = new IPEndPoint(IPAddress.Parse(ipServer), port);
        }

        private void BtnGestion(object sender, EventArgs e)
        {
            string msg;
            string userMsg;
            string comand;

            Socket server = new Socket(
                AddressFamily.InterNetwork,
                SocketType.Stream,
                ProtocolType.Tcp
            );
            try
            {
                server.Connect(ie);
            }
            catch (SocketException ex)
            {
                lblinfo.Text = String.Format(
                    "Error connection: {0}\nError code: {1}({2})",
                    ex.Message,
                    (SocketError)ex.ErrorCode,
                    ex.ErrorCode)
                ;
                return;
            }
            IPEndPoint ieServer = (IPEndPoint)server.RemoteEndPoint;
            Console.WriteLine("Server on IP:{0} at port {1}", ieServer.Address, ieServer.Port);
            using (NetworkStream ns = new NetworkStream(server))
            using (StreamReader sr = new StreamReader(ns))
            using (StreamWriter sw = new StreamWriter(ns))
            {

                comand = ((Button)sender).Tag.ToString();

                if (((Button)sender) == btnClose)
                {
                    comand += " " + txtPass.Text;
                }

                sw.WriteLine(comand);
                sw.Flush();
                lblinfo.Text = sr.ReadLine();
            }
            Console.WriteLine("Ending connection");
            server.Close();
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2(ie);

            if (form.ShowDialog() == DialogResult.OK)
            {
                ipServer = form.txtIp.Text;
                int.TryParse(form.txtPuerto.Text, out port);
            }
        }
    }
}
