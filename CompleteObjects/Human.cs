using System;

namespace Once_Upon_A_Dog
{
    /// <summary>
    /// A human being, alive
    /// </summary>
    public class Human : Creature
    {
        public override void MakeSound(string words)
        {
           Console.WriteLine(words);
        }
    }
}
