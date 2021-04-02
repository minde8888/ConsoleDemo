using System;
using System.Collections.Generic;


namespace ConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var shop = new Shop();

            var go = true;
            while (go)
            {

                string input = Console.ReadLine();
                if (input == "List")
                {
                    shop.GetInfo(); 
                }
                else
                {
                    var results = input.Split(' ');
                    var action = results[0];
                    if (action == "stop")
                    {
                        go = false;
                    }
                    else
                    {
                        var name = results[1].ToLower();

                        int a = 0;
                        int num;
                        foreach (var s in input.Split(' '))
                        {
                            if (int.TryParse(s, out num))
                            {
                                a = num;
                            }
                        }

                        shop.Bay(name, a, action);

                    }


                }

            }
        }
    }
}
