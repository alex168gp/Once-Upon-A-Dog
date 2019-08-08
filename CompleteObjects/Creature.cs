using System;
using System.Collections.Generic;
using System.Threading;

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

        #region Protected Members

        /// <summary>
        /// Default noise for this creature
        /// </summary>
        protected readonly string mNoise;

        /// <summary>
        /// Default console foreground for this creature
        /// </summary>
        protected readonly ConsoleColor mForegroundColor;

        #endregion

        #region Public Properties

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

        /// <summary>
        /// True, if a creature can't eat more
        /// </summary>
        public bool IsFull { get; set; } = false;

        /// <summary>
        /// An inventory and equipped things
        /// </summary>
        public List<Item> Inventory { get; set; } = new List<Item>();

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="name">A name of a creature</param>
        /// <param name="weight">A weight of a creature, can't be negative and higher than 10</param>
        public Creature(string name, int weight, string noise = "Wryyyyyyyyy", ConsoleColor foregroundColor = ConsoleColor.White)
        {
            // Set properties
            Name = name;
            Weight = weight;
            mNoise = noise;
            mForegroundColor = foregroundColor;
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Interact with other living being
        /// </summary>
        /// <param name="living">A creature to interact with</param>
        /// <param name="command">What to do with a creature</param>
        public void PerformAction(Creature creature, Command command, string words = null)
        {
            // If you want to talk
            if (command.Equals(Command.Talk) && creature != null)
                // talk
                MakeSound(creature, words);
            else
                throw new System.Exception("Something is wrong");

            // TODO: Need more interaction
            // TODO: Think about interaction with itself
            // TODO: Exception handling
        }

        /// <summary>
        /// Interact with a thing
        /// </summary>
        /// <param name="nonliving">A thing to interact with</param>
        /// <param name="command">What to do with a thing</param>
        public void PerformAction(Item item, Command command)
        {
            switch (command)
            {
                case Command.Eat:
                    // We can eat only food
                    if (item.IsFood && !IsFull)
                    {
                        // If creature can't eat food entirely...
                        if (Weight + item.Weight > 10)
                        {
                            // eat a part of it
                            Console.WriteLine("{0} ate a part of a {1}, and now full.", Name, item.Name);

                            // How much creature ate
                            item.Weight -= (10 - Weight);

                            // A creature get maximum weight
                            Weight = 10;
                        }
                        // then creature can eat it whole
                        else
                        {
                            // eat food
                            Console.WriteLine("{0} ate a {1}.", Name, item.Name);

                            // Creature get all the weight from a food
                            Weight += item.Weight;

                            // TODO: Find a proper way of disposing food
                            // TODO: Add the ability to eat food that is not in your inventory
                            Inventory.Remove(item);
                        }
                    }
                    else
                        // TODO: Add more variety in handling a situation
                        Console.WriteLine("Can't eat this, for some reason");
                    break;
                case Command.Talk:
                    // TODO: Add a proper handler
                    Console.WriteLine("Why I'm talking to a thing?");
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
        /// Execute action that is out of the basic <see cref="Command"/>s.
        /// Action can't affect anything
        /// </summary>
        /// <param name="action">An action to execute</param>
        public void PerformComplicatedAction(string action)
        {
            // Execute action
            Console.WriteLine("{0} *{1}*", Name, action);
        }

        /// <summary>
        /// Say something
        /// </summary>
        /// <param name="words">Words to say</param>
        public virtual void MakeSound(string words = null)
        {
            // Change color of his words for this creature
            Console.ForegroundColor = mForegroundColor;

            // If we have nothing to say
            if (String.IsNullOrEmpty(words))
                // just make some noise
                Console.WriteLine("{0}: {1}", Name, mNoise);
            else
                // or say what a creature want to say
                Console.WriteLine("{0}: {1}", Name, words);

            // A small pause for words to say
            Thread.Sleep(1000);

            // Reset foreground color
            Console.ResetColor();
        }

        /// <summary>
        /// Say something with another creature
        /// </summary>
        /// <param name="words">Words to say</param>
        /// <param name="creature">Some creature you want to speak with</param>
        public virtual void MakeSound(Creature creature, string words = null)
        {
            // If this creature want to speak to itself
            if (creature == this)
            {
                // let it
                MakeSound(words);

                return;
            }

            // Change color of his words for this creature
            Console.ForegroundColor = mForegroundColor;

            // If we have nothing to say
            if (String.IsNullOrEmpty(words))
                // just make some noise, initiator considered way louder
                Console.WriteLine("{0} and {1}: {2}", Name, creature.Name, mNoise);
            else
                // or say what a creature want to say
                Console.WriteLine("{0} and {1}: {2}", Name, creature.Name, words);

            // Reset foreground color
            Console.ResetColor();
        }

        #endregion
    }
}
