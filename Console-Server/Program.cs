using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Console_Server
{
    class Program
    {
        static Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        static void Main(string[] args)
        {
            
            
                socket.Bind(new IPEndPoint(IPAddress.Any, 904));
                socket.Listen(5);//Слушает подключения. Максимальное количество может обработать.
                Socket client = socket.Accept();//Принятие
                Console.WriteLine("Новое подключение");
                byte[] buffer = new byte[1024];
                int size = client.Receive(buffer);//Получаем от подкюченного сокета данные
                Console.WriteLine(Encoding.ASCII.GetString(buffer, 0, size));//Вывод данных на экран
                Console.ReadLine();
                socket.Shutdown(SocketShutdown.Both);
                socket.Close();// Освобождаем и закрываем порт
            
        }
    }
}