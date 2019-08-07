using System;

namespace Once_Upon_A_Dog
{
    /// <summary>
    /// 
    /// </summary>
    public class Dog : Creature
    {
        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="name">A name of a dog</param>
        /// <param name="weight">A weight of a dog, can't be negative and higher than 10</param>
        public Dog(string name, int weight) : base(name, weight) { }

        #endregion

        #region Public Methods

        /// <summary>
        /// Say something
        /// </summary>
        /// <param name="words">Words to say</param>
        public override void MakeSound(string words)
        {
            // Change foreground color for dogs
            Console.ForegroundColor = ConsoleColor.Cyan;

            // If we have nothing to say
            if (String.IsNullOrEmpty(words))
                // just make some noise
                Console.WriteLine("{0}: Woof", Name);
            else
                // Say something
                Console.WriteLine("{0}: {1}", Name, words);

            // Reset foreground color
            Console.ResetColor();
        } 

        #endregion
    }
}
