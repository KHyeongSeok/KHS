using System.Collections.Concurrent;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace hj20250527_SocketServerConsole
{
    internal class Program
    {
        static ConcurrentBag<TcpClient> connectedClients = new ConcurrentBag<TcpClient>();
        // async : 비동기 10초, 100초 => 10 + 110 = 120
        // sync : 동기  100초 , 10초 => 100 + 110 = 210
        static async Task Main(string[] args)
        {
            Console.WriteLine("서버 시작!");
            // 인터넷 주소: IP주소(컴퓨터 주소) + port주소(앱 주소)
            TcpListener server = new TcpListener(IPAddress.Any, 9000);
            try
            {
                server.Start();
                Console.WriteLine("서버가 실행 됨(포트9000)");
                while (true) {
                    Console.WriteLine("클라이언트 기다려요");
                    TcpClient client = await server.AcceptTcpClientAsync();
                    connectedClients.Add(client);
                    Console.WriteLine($"클라이언트 연결 되었어요 {
                        client.Client.RemoteEndPoint}");
                    HandleClientAsync(client);
                }

            }
            catch (Exception ex) { 
                Console.WriteLine($"서버 오류 발생: {ex.Message}");
            }
            finally
            {
                server.Stop();
            }
        }
        static async Task HandleClientAsync(TcpClient client)
        {
            Console.WriteLine("HandleClientAsync 시작");
            NetworkStream stream = null;
            try
            {
                stream = client.GetStream();
                Console.WriteLine("Stream Ok!");
                byte [] buffer = new byte[1024];
                int bytesRead;
                while((bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length)) > 0)
                {
                    string receivedMessage = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    Console.WriteLine(
                    $"수신내용: {receivedMessage} from {client.Client.RemoteEndPoint}"
                    );
                    //Option : broadcast
                    string fullMessage = $"{client.Client.RemoteEndPoint}: {receivedMessage}";
                    // 나도 포함 방송 해
                    //await BroadcastMessageAsync(fullMessage);
                    // 나는 빼고 방송 해
                    await BroadcastMessageAsync(fullMessage, excludedClient: client);

                }
                Console.WriteLine($"클라이언트 ({client.Client.RemoteEndPoint}) 연결 종료 됨");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"클라이언트 처리 중 오류: {ex.Message}");
            }
            finally
            {
                stream?.Close();
                client?.Close();
                Console.WriteLine($"클라이언트 {client.Client.RemoteEndPoint} 연결 종료 됨");
            }
        }

        static async Task BroadcastMessageAsync(string message, TcpClient excludedClient = null)
        {
            //www.urlencoder.org/ko
            byte[] messageBytes = Encoding.UTF8.GetBytes(message);
            foreach(var client in 
                connectedClients.Where(c=>c.Connected && c != excludedClient))
            {
                try
                {
                    var stream = client.GetStream();
                    await stream.WriteAsync(messageBytes, 0, messageBytes.Length);
                }
                catch { }
            }
        }
    }

}