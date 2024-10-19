using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDemo
{
    internal interface IState
    {
        void SendMessage(string message);
    }

    public class ActiveState : IState
    {
        public void SendMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ForegroundColor= ConsoleColor.White;
        }
        public override string ToString()
        {
            return "активный";
        }
    }
    public class BannedState : IState
    {
        public void SendMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("пользователь не имеет права отправить сообщение");
            Console.ForegroundColor= ConsoleColor.White;
        }
        public override string ToString()
        {
            return "заблокированный";
        }
    }
    public class SuspendedState : IState
    {
        public void SendMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("сообщение поставлено в очередь");
            Console.ForegroundColor= ConsoleColor.White;
        }
        public override string ToString()
        {
            return "ожидающий";
        }
    }

}
