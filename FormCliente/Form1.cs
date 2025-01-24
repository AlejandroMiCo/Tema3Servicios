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

namespace FormCliente//Titulo, icono, info textbox password, comprobar puerto e ip válidos, pass oculta, uso de tag
{
    public partial class Form1 : Form
    {
        string ipServer = "127.0.0.1";
        int port = 16180;

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnGestion(object sender, EventArgs e)
        {
            string msg;
            string userMsg;
            string comand;
            // Indicamos servidor al que nos queremos conectar y puerto
            IPEndPoint ie = new IPEndPoint(IPAddress.Parse(ipServer), port);
            //Console.WriteLine("Starting client. Press a key to initconnection");


            //Console.ReadKey();
            Socket server = new Socket(
                AddressFamily.InterNetwork,
                SocketType.Stream,
                ProtocolType.Tcp
            );
            try
            {
                // El cliente inicia la conexión haciendo petición con Connect
                server.Connect(ie);
            }
            catch (SocketException ex)
            {
                Console.WriteLine(
                    "Error connection: {0}\nError code: {1}({2})",
                    ex.Message,
                    (SocketError)ex.ErrorCode,
                    ex.ErrorCode
                );
                return;
            }
            // Información del servidor
            IPEndPoint ieServer = (IPEndPoint)server.RemoteEndPoint;
            Console.WriteLine("Server on IP:{0} at port {1}", ieServer.Address, ieServer.Port);
            // Si la conexión se ha establecido se crean los Streams
            // y se inicial la comunicación siguiendo el protocolo
            // establecido en el servidor
            using (NetworkStream ns = new NetworkStream(server))
            using (StreamReader sr = new StreamReader(ns))
            using (StreamWriter sw = new StreamWriter(ns))
            {

                comand = "";
                switch (sender)
                {
                    case object x when x == btnTime:
                        comand = "time";
                        break;
                    case object x when x == btnDate:
                        comand = "date";
                        break;
                    case object x when x == btnAll:
                        comand = "all";
                        break;
                    default:
                        comand = "close " + txtPass.Text;
                        break;
                }

                sw.WriteLine(comand);
                sw.Flush();
                lblinfo.Text = sr.ReadLine();
            }
            Console.WriteLine("Ending connection");
            //Indicamos fin de transmisión.
            server.Close();
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2(ipServer, port);


            if (form.ShowDialog() == DialogResult.OK)
            {
                ipServer = form.txtIp.Text;
                int.TryParse(form.txtPuerto.Text, out port);

                Console.WriteLine(port);
            }
        }
    }
}
