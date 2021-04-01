using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var shop = new Shop();

            shop.Buy();

            var books = new Books();

            var list = "labas";

            shop.GetInfo(list);
        }
    }
}
