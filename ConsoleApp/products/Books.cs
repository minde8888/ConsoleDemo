using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Books
    {

        internal void getItems(int b, string c)
        {
            var item = new Items();
            if (c == "add")
            {
                item.Books = item.Books + b;
            }
            else if(c == "bay" && item.Books >= b)
            {
                 item.Books = item.Books - b;
            }
            else
            {
                Console.WriteLine("there are not so many goods");
            }

           
        }
    }
}
