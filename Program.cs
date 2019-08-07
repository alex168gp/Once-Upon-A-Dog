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
            hum.Weight = 2;
            var f = new Item("ask", 1);
            f.IsFood = true;
            hum.Inventory.Add(f);
            hum.Inventory.Add(new Item("as2k", 123));
            hum.Inventory.Add(new Item("assas2k", 121233));
            hum.ExecuteAction(f, Command.Eat);
            Console.ReadKey();
        } 

        #endregion
    }
}
