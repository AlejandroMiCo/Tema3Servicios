using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        static bool isServerRunning = true;
        static string pass;

        static void Main(string[] args)
        {
            IPEndPoint ie = new IPEndPoint(IPAddress.Any, 11111);
            Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            s.Bind(ie);
            s.Listen(10);
            using (
                StreamReader sr = new StreamReader(
                    Environment.GetEnvironmentVariable("PROGRAMDATA") + "\\Server\\pass.txt"
                )
            )
            {
                pass = sr.ReadToEnd();
            }
            Console.Write(pass);
            Console.WriteLine("Server waiting at port {0}", ie.Port);
            while (isServerRunning)
            {
                Socket cliente = s.Accept();
                Thread hilo = new Thread(hiloCliente);
                hilo.IsBackground = true;
                hilo.Start(cliente);
            }

            if (!isServerRunning)
            {
                s.Close();
            }
        }

        static void hiloCliente(object socket)
        {
            string mensaje;
            Socket cliente = (Socket)socket;
            IPEndPoint ieCliente = (IPEndPoint)cliente.RemoteEndPoint;
            Console.WriteLine(
                "Connected with client {0} at port {1}",
                ieCliente.Address,
                ieCliente.Port
            );
            using (NetworkStream ns = new NetworkStream(cliente))
            using (StreamReader sr = new StreamReader(ns))
            using (StreamWriter sw = new StreamWriter(ns))
            {
                try
                {
                    mensaje = sr.ReadLine();

                    //El mensaje es null al cerrar
                    if (mensaje != null)
                    {
                        Console.WriteLine("{0} says: {1}", ieCliente.Address, mensaje);
                        if (mensaje.StartsWith("close"))
                        {
                            if (mensaje.ToString().Length > 6)
                            {
                                if (mensaje == ("close ") + pass)
                                {
                                    isServerRunning = false;
                                    sw.WriteLine("Server has stoped");
                                    sw.Flush();
                                }
                                else
                                {
                                    sw.WriteLine("Error, incorrect password");
                                    sw.Flush();
                                }
                            }
                            else
                            {
                                sw.WriteLine("Error, no password has been sent");
                                sw.Flush();
                            }
                        }
                        else
                        {
                            switch (mensaje)
                            {
                                case "time":
                                    sw.WriteLine(DateTime.Now.ToLongTimeString());
                                    break;
                                case "date":
                                    sw.WriteLine(DateTime.Now.ToShortDateString());
                                    break;

                                case "all":
                                    sw.WriteLine(DateTime.Now.ToString());
                                    break;
                                default:
                                    sw.WriteLine(mensaje+" is not a valid comand");
                                    break;
                            }
                            sw.Flush();
                        }
                    }
                }
                catch (IOException)
                {
                    //Salta al acceder al socket
                    //y no estar permitido
                }
                Console.WriteLine(
                    "Finished connection with {0}:{1}",
                    ieCliente.Address,
                    ieCliente.Port
                );
            }
            cliente.Close();
        }
    }
}
