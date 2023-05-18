using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AppVision
{
    public class Server
    {
        private static Socket listener;
        public const int _port = 1000;
        public static bool _isRunning = true;
        public const int _bufferSize = 1024;

        public static ManualResetEvent allDone = new ManualResetEvent(false);


        public delegate void ReceiveStringDelegate(string rev, Socket socket);
        public static event ReceiveStringDelegate eventReceiveString;

        class StateObject
        {
            public Socket workSocket = null;
            public byte[] buffer = new byte[_bufferSize];
            public StringBuilder sb = new StringBuilder();
        }

        public void Start()
        {
            IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
            IPEndPoint localEP = new IPEndPoint(IPAddress.Any, _port);
            listener = new Socket(localEP.Address.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            listener.Bind(localEP);

            while (_isRunning)
            {
                Console.WriteLine("Server is start listening!!!");
                allDone.Reset();
                listener.Listen(10);
                listener.BeginAccept(new AsyncCallback(acceptCallback), listener);
                bool isRequest = allDone.WaitOne(new TimeSpan(12, 0, 0));  // Blocks for 12 hours

                if (!isRequest)
                {
                    allDone.Set();
                    // Do some work here every 12 hours
                }
            }
            listener.Close();
        }

        static void acceptCallback(IAsyncResult ar)
        {
            // Get the listener that handles the client request.
            Socket listener = (Socket)ar.AsyncState;

            if (listener != null)
            {
                Socket handler = listener.EndAccept(ar);

                // Signal main thread to continue
                allDone.Set();

                // Create state
                StateObject state = new StateObject();
                state.workSocket = handler;
                handler.BeginReceive(state.buffer, 0, _bufferSize, 0, new AsyncCallback(readCallback), state);
            }
        }

        // Checks if the socket is connected
        static bool IsSocketConnected(Socket s)
        {
            return !((s.Poll(1000, SelectMode.SelectRead) && (s.Available == 0)) || !s.Connected);
        }
        static void readCallback(IAsyncResult ar)
        {
            StateObject state = (StateObject)ar.AsyncState;
            Socket handler = state.workSocket;

            if (!IsSocketConnected(handler))
            {
                handler.Close();
                return;
            }

            int read = handler.EndReceive(ar);

            // Data was read from the client socket.
            if (read > 0)
            {
                state.sb.Append(Encoding.UTF8.GetString(state.buffer, 0, read));

                if (state.sb.ToString().Contains(","))
                {
                    string toSend = "";
                    string cmd = state.sb.ToString();

                    switch (cmd)
                    {
                        case "Hi!":
                            toSend = "How are you?";
                            break;
                        case "Milky Way?":
                            toSend = "No I am not.";
                            break;
                        case "Date":
                            // Nếu event được theo dõi, thì kích hoạt event, gửi theo Socket
                            if (eventReceiveString != null) eventReceiveString(cmd, handler);
                            break;
                        default:
                            if (eventReceiveString != null) eventReceiveString(cmd, handler);
                            break;
                    }

                    //toSend = toSend + " Received!\r\n";
                    toSend = "";
                    byte[] bytesToSend = Encoding.UTF8.GetBytes(toSend);
                    handler.BeginSend(bytesToSend, 0, bytesToSend.Length, SocketFlags.None
                        , new AsyncCallback(sendCallback), state);
                }
                else
                {
                    handler.BeginReceive(state.buffer, 0, _bufferSize, 0
                            , new AsyncCallback(readCallback), state);
                }
            }
            else
            {
                handler.Close();
            }
        }
        static void sendCallback(IAsyncResult ar)
        {
            StateObject state = (StateObject)ar.AsyncState;
            Socket handler = state.workSocket;
            handler.EndSend(ar);

            StateObject newstate = new StateObject();
            newstate.workSocket = handler;
            handler.BeginReceive(newstate.buffer, 0, _bufferSize, 0, new AsyncCallback(readCallback), newstate);
        }
    }
}
