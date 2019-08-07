using System;
using System.Linq;

namespace Once_Upon_A_Dog
{
    class Program
    {
        #region Main

        static void Main(string[] args)
        {
            Human hum = new Human();
            var f = new Item("ask", 12);
            hum.Backpack.Add(f);
            hum.Backpack.Add(new Item("as2k", 123));
            hum.Backpack.Add(new Item("assas2k", 121233));
            Console.ReadKey();
        } 

        #endregion
    }
}
