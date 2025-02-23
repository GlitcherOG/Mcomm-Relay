using System.Net.Sockets;
using System.Net;

namespace Mcomm_Relay
{
    internal class Program
    {
        private TcpClient TCPClient = new TcpClient();
        private UdpClient UDPClient = new UdpClient();
        private UdpClient GameUDPClient = new UdpClient();

        private Thread ThreadTCPListen;
        private Thread ThreadUDPListen;

        static void Main(string[] args)
        {
            //Connect to main server

            //Main Server Listener
            




            UdpClient udpServer = new UdpClient(11000);
            udpServer.ExclusiveAddressUse = false;
            udpServer.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            //udpServer.Client.Bind();
        }


        //host
        //
    }
}
