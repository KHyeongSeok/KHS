﻿using System.IO;
using System.Net.Sockets;

namespace _250527_SocketClientConsole
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
                Console.WriteLine("서버에 연결됨");
                stream = client.GetStream();
                Console.WriteLine("스트림 열림");
                RecieveMessageAsync(stream);
                while (true)
                {
                    // 사용자 입력 처리 루프 : 내일(5-28) 오전에 계속
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                stream?.Close();
                client?.Close();
                Console.WriteLine("클라이언트 종료");
            }
        }
        static async Task RecieveMessageAsync(NetworkStream stream)
        {
            byte[] buffer = new byte[1024];
            try
            {
                // 내일(5-28)  채울 것
            }
            catch (ObjectDisposedException ex)
            {
                Console.WriteLine("메세지 수신 스트림이 닫혔다");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"서버 연결 끊김 : {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"메세지 수신 중 오류 발생 : {ex.Message}");
            }
        }
    }
}
