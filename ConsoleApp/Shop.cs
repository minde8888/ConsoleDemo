using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    internal class Shop
    {

        public void Bay(string a, int b, string c)
        {
            switch (a)
            {
                case "candy":
                    var candy = new Candys();
                    candy.getItems(b, c);
                    break;
                case "cup":
                    var cup = new Cups();
                    cup.getItems(b, c);
                    break;
                case "book":
                    var book = new Books();
                    book.getItems(b, c);
                    break;
                default:
                    Console.WriteLine("The color is unknown.");
                    break;
            }
        }

        public void  GetInfo()
        {
            var item = new Items();

            List<int> list = new List<int>() { item.Books, item.Candy, item.Cups };

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == 0)
                {
                    i++;
                }
                else
                {
                    Console.WriteLine($"{ item.Name[i]} = {list[i]}");
                }
            }
        }


    }
}
