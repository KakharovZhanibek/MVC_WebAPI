using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soap_Client
{
    class Program
    {
        static void Main(string[] args)
        {
            WS.WSSoapClient wSSoapClient = new WS.WSSoapClient();
            WS.Book book=wSSoapClient.First(3);
            Console.WriteLine(book.Id + " " + book.Name + " " + book.Author + " " + book.Year);

            foreach (WS.Book item in wSSoapClient.GetAll())
            {
                Console.WriteLine(item.Id);
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Author);
                Console.WriteLine(item.Year);
                Console.WriteLine("____________________");
            }
        }
    }
}
