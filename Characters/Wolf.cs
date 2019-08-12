using System;

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
        public Wolf(string name, int weight) : base(name, weight, "Awooooooo", ConsoleColor.Red) { }

        #endregion
    }
}
