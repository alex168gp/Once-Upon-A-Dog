using System.Collections.Generic;

namespace Once_Upon_A_Dog
{
    /// <summary>
    /// Describes behavior and properties of a living being
    /// </summary>
    public interface ILiving : IBaseExistence
    {
        #region Properties

        /// <summary>
        /// True, if a creature can't eat more
        /// </summary>
        bool IsFull { get; set; }

        /// <summary>
        /// An inventory and equipped things
        /// </summary>
        List<Item> Backpack { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Interact with other living being
        /// </summary>
        /// <param name="living">A creature to interact with</param>
        /// <param name="command">What to do with a creature</param>
        void ExecuteAction(ILiving living, Command command);

        /// <summary>
        /// Interact with a thing
        /// </summary>
        /// <param name="nonliving">A thing to interact with</param>
        /// <param name="command">What to do with a thing</param>
        void ExecuteAction(INonliving nonliving, Command command);

        /// <summary>
        /// Say something
        /// </summary>
        /// <param name="words">Words to say</param>
        void MakeSound(string words);

        /// <summary>
        /// Eat something
        /// </summary>
        /// <param name="food"></param>
        void Eat(Item food);

        #endregion
    }
}
