using System;

namespace Once_Upon_A_Dog
{ 
    /// <summary>
    /// 
    /// </summary>
    public class Wolf : Creature
    {
        public override void MakeSound(string words)
        {
            if (String.IsNullOrEmpty(words))
                Console.WriteLine("Awoooo");
            else
                Console.WriteLine(words);
        }
    }
}
