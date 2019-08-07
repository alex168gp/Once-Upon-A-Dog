using System.Collections.Generic;

namespace Once_Upon_A_Dog
{
    /// <summary>
    /// A human being, alive
    /// </summary>
    public class Human : Creature
    {

        #region Private Members

        /// <summary>
        /// How heavy a human
        /// </summary>
        private int mWeight;

        #endregion

        #region Public Properties

        /// <summary>
        /// True, if a creature can't eat more
        /// </summary>
        public bool IsFull { get; set; }

        /// <summary>
        /// An inventory and equipped things
        /// </summary>
        public List<Item> Backpack { get; set; } = new List<Item>();

        /// <summary>
        /// A name of a human
        /// </summary>
        public string Name { get; set; } = "No name";

        /// <summary>
        /// How heavy a human
        /// </summary>
        public int Weight
        {
            get => mWeight;
            set
            {
                // Weight can't be negative
                if (value < 0)
                    throw new System.ArgumentException("Weight should be more than or equal 0");

                // Set new value
                mWeight = value;
            }
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Interact with other living being
        /// </summary>
        /// <param name="living">A creature to interact with</param>
        /// <param name="command">What to do with a creature</param>
        public void ExecuteAction(ILiving living, Command command)
        {

        }

        /// <summary>
        /// Interact with a thing
        /// </summary>
        /// <param name="nonliving">A thing to interact with</param>
        /// <param name="command">What to do with a thing</param>
        public void ExecuteAction(INonliving nonliving, Command command)
        {

        }

        /// <summary>
        /// Create noise
        /// </summary>
        public void MakeSound()
        {

        }

        /// <summary>
        /// Say something
        /// </summary>
        /// <param name="words">Words to say</param>
        public void MakeSound(string words)
        {

        }

        /// <summary>
        /// Eat something
        /// </summary>
        /// <param name="food"></param>
        public void Eat(Item food)
        {

        }

        #endregion
    }
}
