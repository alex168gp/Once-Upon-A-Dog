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
        public override void MakeSound(string words)
        {
            // Say something
            Console.WriteLine(words);
        } 

        #endregion

    }
}
