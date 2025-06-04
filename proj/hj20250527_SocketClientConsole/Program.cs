using System.IO;
using System.Net.Sockets;
using System.Text;

namespace hj20250527_SocketClientConsole
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("클라이언트 시작");
            TcpClient client = null;
            NetworkStream stream = null;
            try
            {
                client = new TcpClient();
                Console.WriteLine("서버에 연결 중");
                await client.ConnectAsync("127.0.0.1", 9000);
                Console.WriteLine("서버에 연결 됨");
                stream = client.GetStream();
                Console.WriteLine("스트림 열림");
                RecieveMessageAsync(stream);
                while (true)
                {
                    // 사용자 입력 처리 루프 : 서버에게 보낼 메세지 처리
                    Console.Write("하고 싶은말 입력(종료하려면 exit 입력):");
                    string messageToSend = Console.ReadLine();
                    if (string.IsNullOrEmpty(messageToSend))
                    {
                        Console.WriteLine("메세지를 다시 입력하세요");
                        continue;
                    }                        
                    if( messageToSend.ToLower()=="exit")
                    {
                        Console.WriteLine("클라이언트를 종료합니다.");
                        break;
                    }
                    // 서버로 전송
                    byte[] data = Encoding.UTF8.GetBytes(messageToSend);
                    await stream.WriteAsync(data, 0, data.Length);
                    Console.WriteLine("메세지가 서버로 잘 갔어요");
                }
            }
            catch (SocketException ex)
            {
                Console.WriteLine($"소켓 오류: {ex.Message}");
            }
            catch (Exception ex) 
            { 
                Console.WriteLine($"일반 오류: {ex.Message}"); 
            }
            finally
            {
                stream?.Close();
                client?.Close();
                Console.WriteLine("클라이언트 종료");
            }
        }
        // 서버로부터 메세지를 수신하는 메소드(함수)
        static async Task RecieveMessageAsync(NetworkStream stream)
        {
            byte[] buffer = new byte[1024];
            try
            {
                while (true)
                {
                    int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
                    if (bytesRead == 0)
                    {
                        Console.WriteLine("서버가 연결을 닫았습니다. ");
                        break;
                    }
                    string receivedMessage = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    Console.WriteLine($"수신: {receivedMessage}");
                    Console.Write("하고 싶은말 입력(종료하려면 exit 입력):");
                }
            }
            catch (ObjectDisposedException ex)
            {
                Console.WriteLine("메세지 수신 스트림이 닫혔다");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"서버 연결 끊김: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"메세지 수신 중 오류 발생: {ex.Message}");
            }
        }
    }
}
