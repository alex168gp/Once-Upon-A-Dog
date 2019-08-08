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
        public Dog(string name, int weight) : base(name, weight, "WoofWoof", ConsoleColor.Cyan) { }

        #endregion
    }
}
