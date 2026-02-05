using System;
using System.Collections.Generic;
using System.Text;

namespace class11142022
{
    class Tunnel
    {
        public char[] tunnel = { '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#' };

        public void PrintTunnel()
        {
            foreach (char items in tunnel)
            {
                Console.Write(items + "|");
            }
            Console.WriteLine();
        }
    }
}
