using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;

namespace GameCaro
{
    class SocketManager
    {

        #region Sever
        Socket sever;
        public void CreateServer()
        {
            IPEndPoint iep = new IPEndPoint(IPAddress.Parse(IP), PORT);
            sever = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            sever.Bind(iep);
            sever.Listen(10);
            Thread acceptClient = new Thread(() =>
            {
                client = sever.Accept();
            });
            acceptClient.IsBackground = true;
            acceptClient.Start();
        }
        #endregion

        #region Client
        Socket client;
        public bool ConnectServer()
        {
            IPEndPoint iep = new IPEndPoint(IPAddress.Parse(IP), PORT);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                client.Connect(iep);
                return true;
            }
            catch
            {
                return false;
            }
            
        }
        #endregion

        #region Both
        public int PORT = 9999;
        public string IP = "";
        public int Leght = 1024;
        public bool Send(object data)
        {
            byte[] dataSend = SerializeData(data);
            return SendData(client, dataSend);
        }
        public object Receive()
        {
            byte[] dataReceive = new byte[Leght];
            bool isOK = ReceiveData(client, dataReceive);
            return DeserializeData(dataReceive);
        }

        private bool SendData(Socket taget ,byte[] data)
        {
            return taget.Send(data) == 1 ? true : false;
        }
        private bool ReceiveData(Socket taget, byte[] data)
        {
            return taget.Receive(data) == 1 ? true : false;
        }
        // Change object to array bite[]
        public byte[] SerializeData(Object o)
        {
            MemoryStream ms = new MemoryStream();
            BinaryFormatter bf1 = new BinaryFormatter();
            bf1.Serialize(ms, o);
            return ms.ToArray();
        }
        // Change array bite[] to object
        public object DeserializeData(byte[] theByteArray)
        {
            MemoryStream ms = new MemoryStream(theByteArray);
            BinaryFormatter bf1 = new BinaryFormatter();
            ms.Position = 0;
            return bf1.Deserialize(ms);
        }
        // Get IPv4 Address
        public static string GetLocalIPv4(NetworkInterfaceType _type)
        {
            string output = "";
            foreach (NetworkInterface item in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (item.NetworkInterfaceType == _type && item.OperationalStatus == OperationalStatus.Up)
                {
                    foreach (UnicastIPAddressInformation ip in item.GetIPProperties().UnicastAddresses)
                    {
                        if (ip.Address.AddressFamily == AddressFamily.InterNetwork)
                        {
                            output = ip.Address.ToString();
                        }
                    }
                }
            }
            return output;
        }
        #endregion


    }
}
