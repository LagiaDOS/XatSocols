using System;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace XatSocols
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {



            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

            var client = new Client();
            client.Run();
            Console.ReadKey();

        }

        class Client { 
        
            public string ServerAddress { get; }
            public int Port { get;}

            public Client() {
                ServerAddress = "localhost";
                Port = 32000;
            }

            public void Run() {

            



            var client = new TcpClient(ServerAddress, Port);

                try
                {
                    using (NetworkStream canal = client.GetStream())
                    {
                        BinaryReader input = new BinaryReader(canal);
                        BinaryWriter output = new BinaryWriter(canal);
                        String missatge = null;

                        do
                        {
                            Console.Write("Introdueix el missatge a enviar:");
                            Console.Write("Escriu 0 per parar el client: ");

                            //debug
                            missatge = "missatge de proba";
                            missatge = Console.ReadLine();
                            output.Write(missatge);
                            output.Flush();
                            missatge = input.ReadString();

                            //debug, posar misatge del log

                            //Console.WriteLine(missatge);


                        }
                        while (missatge != "0");


                    }




                }
                catch (SocketException e) {
                Console.WriteLine(e.Message);
                }
                finally { 
                client.Close();
                client.Dispose();
                }



            }


        }
    
    
    }
}