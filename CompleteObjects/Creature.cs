using System;
using System.Collections.Generic;

namespace Once_Upon_A_Dog
{
    /// <summary>
    /// Base living creature
    /// </summary>
    public class Creature : ILiving
    {
        #region Private Members

        /// <summary>
        /// How heavy a creature
        /// </summary>
        private int mWeight;

        #endregion

        #region Public Properties

        /// <summary>
        /// True, if a creature can't eat more
        /// </summary>
        public bool IsFull { get; set; } = false;

        /// <summary>
        /// An inventory and equipped things
        /// </summary>
        public List<Item> Inventory { get; set; } = new List<Item>();

        /// <summary>
        /// A name of a creature
        /// </summary>
        public string Name { get; set; } = "No name";

        /// <summary>
        /// How heavy a creature
        /// </summary>
        public int Weight
        {
            get => mWeight;
            set
            {
                // Weight can't be negative or higher than 10
                if (value < 0 || value > 10)
                    throw new System.FormatException("Weight should be more than 0 or lower than 10");
                // creature can have a maximum weight of 10
                else if (value == 10)
                    // and it become full and can't eat more
                    IsFull = true;

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
        public void ExecuteAction(Creature creature, Command command, string words = "")
        {
            // If you want to talk
            if (command.Equals(Command.Talk) && creature != null)
                // talk
                MakeSound(words);

            // TODO: Need more interaction
            // TODO: Exception handling
        }

        /// <summary>
        /// Interact with a thing
        /// </summary>
        /// <param name="nonliving">A thing to interact with</param>
        /// <param name="command">What to do with a thing</param>
        public void ExecuteAction(Item item, Command command)
        {
            switch (command)
            {
                case Command.Eat:
                    // We can eat only food
                    if (item.IsFood && !IsFull)
                    {
                        // If we can't eat food entirely...
                        if (mWeight + item.Weight > 10)
                        {
                            // eat a part of it
                            Console.WriteLine("You ate a part of a food, and now you're full");

                            // How much creature ate
                            item.Weight -= (10 - mWeight);

                            // A creature get maximum weight
                            mWeight = 10;
                        }
                        else
                        {
                            // We can eat a whole food item
                            mWeight += item.Weight;

                            // TODO: Add the ability to eat food that is not in your inventory
                            Inventory.Remove(item);
                        }
                    }
                    else
                        // TODO: Add more variety in handling a situation
                        Console.WriteLine("Can't eat this, for some reason");
                    break;
                case Command.Talk:
                    break;
                case Command.Take:
                    // If we have item...
                    if (item != null)
                        // take it
                        Inventory.Add(item);
                    else
                        // TODO: add some handler
                        Console.WriteLine("There is no item to take");
                    break;
                case Command.Give:
                    throw new System.NotImplementedException("Give is not implemented");
                    break;
                case Command.Kick:
                    throw new System.NotImplementedException("Kick is not implemented");
                    break;
                default:
                    Console.WriteLine("You used unknown command, I don't know how");
                    break;
            }
        }

        /// <summary>
        /// Say something
        /// </summary>
        /// <param name="words">Words to say</param>
        public virtual void MakeSound(string words)
        {
            // If we have nothing to say
            if (String.IsNullOrEmpty(words))
                // just make some noise
                Console.WriteLine("{0}: Wryyyyyyyyy", Name);
            else
                // or say what a creature want to say
                Console.WriteLine("{0}: {1}",Name, words);
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="name">A name of a creature</param>
        /// <param name="weight">A weight of a creature, can't be negative and higher than 10</param>
        public Creature(string name, int weight)
        {
            // Set properties
            Name = name;
            Weight = weight;
        } 

        #endregion
    }
}
