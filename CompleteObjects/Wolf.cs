using System;

namespace Once_Upon_A_Dog
{ 
    /// <summary>
    /// 
    /// </summary>
    public class Wolf : Creature
    {
        /// <summary>
        /// Say something
        /// </summary>
        /// <param name="words">Words to say</param>
        public override void MakeSound(string words)
        {
            // If we have nothing to say
            if (String.IsNullOrEmpty(words))
                // just make some noise
                Console.WriteLine("Awoooooo");
            else
                // Say something
                Console.WriteLine(words);
        }
    }
}
