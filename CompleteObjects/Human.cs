using System;

namespace Once_Upon_A_Dog
{
    /// <summary>
    /// A human being, alive
    /// </summary>
    public class Human : Creature
    {
        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="name">A name of a human</param>
        /// <param name="weight">A weight of a human, can't be negative and higher than 10</param>
        public Human(string name, int weight) : base(name, weight) { }

        #endregion

        #region Public Methods

        /// <summary>
        /// Say something
        /// </summary>
        /// <param name="words">Words to say</param>
        public override void MakeSound(string words = null)
        {
            // Change foreground color for humans
            Console.ForegroundColor = ConsoleColor.Yellow;

            // If we have nothing to say
            if (String.IsNullOrEmpty(words))
                // just make some noise
                Console.WriteLine("{0}: AAAAAAAAAAAAA", Name);
            else
                // Say something
                Console.WriteLine("{0}: {1}", Name, words);

            // Reset foreground color
            Console.ResetColor();
        }

        /// <summary>
        /// Say something with another creature
        /// </summary>
        /// <param name="words">Words to say</param>
        /// <param name="creature">Some creature you want to speak with</param>
        public override void MakeSound(Creature creature, string words = null)
        {
            // If this human want to speak to itself
            if (creature == this)
            {
                // let it
                MakeSound(words);

                return;
            }

            // Change foreground color for humans
            Console.ForegroundColor = ConsoleColor.Yellow;

            // If we have nothing to say
            if (String.IsNullOrEmpty(words))
                // just make some noise, initiator considered way louder
                Console.WriteLine("{0} and {1}: AAAAAAAAAAAAA", Name, creature.Name);
            else
                // or say what a creature want to say
                Console.WriteLine("{0} and {1}: {2}", Name, creature.Name, words);

            // Reset foreground color
            Console.ResetColor();
        }

        #endregion

    }
}
