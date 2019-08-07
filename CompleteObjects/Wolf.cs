﻿using System;

namespace Once_Upon_A_Dog
{ 
    /// <summary>
    /// 
    /// </summary>
    public class Wolf : Creature
    {
        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="name">A name of a wolf</param>
        /// <param name="weight">A weight of a wolf, can't be negative and higher than 10</param>
        public Wolf(string name, int weight) : base(name, weight) { }

        #endregion

        #region Public Methods

        /// <summary>
        /// Say something
        /// </summary>
        /// <param name="words">Words to say</param>
        public override void MakeSound(string words)
        {
            // Change foreground color for wolfs
            Console.ForegroundColor = ConsoleColor.Red;

            // If we have nothing to say
            if (String.IsNullOrEmpty(words))
                // just make some noise
                Console.WriteLine("{0}: Awoooooo", Name);
            else
                // Say something
                Console.WriteLine("{0}: {1}", Name, words);

            // Reset foreground color
            Console.ResetColor();
        } 

        #endregion
    }
}
