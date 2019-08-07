using System;

namespace Once_Upon_A_Dog
{
    /// <summary>
    /// 
    /// </summary>
    public class Dog : Creature
    {
        public override void MakeSound(string words)
        {
            if (String.IsNullOrEmpty(words))
                Console.WriteLine("Woof");
            else
                Console.WriteLine(words);
        }
    }
}
