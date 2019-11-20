using System;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace SocketClient
{
    class Program
    {
        static Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        /*Класс Socket для сетевого взаимодействия
         * AddressFamily: возвращает все адреса, используемые сокетом, InterNetwork: адрес по протоколу IPv4
         * SocketType: возвращает тип сокета, Stream: обеспечивает надежную двустороннюю передачу данныx
         * ProtocolType: возвращает одно из значений перечисления*/

        static void Main (string[] args)
        {
            
         socket.Connect("127.0.0.1", 904);//Подключение к серверу
          string message = Console.ReadLine();//Считываем сообщение пользователя
          byte[] buffer = Encoding.ASCII.GetBytes(message);//Кодировка массива байтов
          socket.Send(buffer);//Отправка  
          while (true)
          {
          Console.ReadLine();
          }
          socket.Shutdown(SocketShutdown.Both);
          socket.Close();
                
            
        }
    }
 
}