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

        /// <summary>
        /// Determines a kick power of a creature
        /// </summary>
        Random KickPower = new Random();

        #endregion

        #region Protected Members

        /// <summary>
        /// Default noise for this creature
        /// </summary>
        protected readonly string Noise;

        /// <summary>
        /// Default console foreground for this creature
        /// </summary>
        protected readonly ConsoleColor ForegroundColor;

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
                if (value > 10)
                    throw new System.FormatException("Weight should be lower than 10");
                // creature can have a maximum weight of 10
                else if (value == 10)
                    // and it become full and can't eat more
                    IsFull = true;
                // Creature is dead
                else if (value <= 0)
                    MakeSound(Name + " is dead.");

                // TODO: dispose of the dead

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
            Noise = noise;
            ForegroundColor = foregroundColor;
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Eat specified item
        /// </summary>
        /// <param name="food">food to eat</param>
        private void EatFood(Item food)
        {
            // Can't eat if you're full or it's not food
            if (IsFull || !food.IsFood)
            {
                Console.WriteLine("Can't eat this, for some reason");
                return;
            }
                
            // If creature can't eat food entirely...
            if (Weight + food.Weight > 10)
            {
                // eat a part of it
                Console.WriteLine("{0} ate a part of a {1}, and now full.", Name, food.Name);

                // How much creature ate
                food.Weight -= (10 - Weight);

                // A creature get maximum weight
                Weight = 10;
            }
            // then creature can eat it whole
            else
            {
                // eat food
                Console.WriteLine("{0} ate a {1}.", Name, food.Name);

                // Creature get all the weight from a food
                Weight += food.Weight;

                food.Weight = 0;

                // TODO: Find a proper way of disposing food
                // TODO: Add the ability to eat food that is not in your inventory
                Inventory.Remove(food);
            }
        }

        private void TakeItem(Creature creature, Item item)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Interact with other living being
        /// </summary>
        /// <param name="living">A creature to interact with</param>
        /// <param name="command">What to do with a creature</param>
        public void PerformAction(Creature creature, Command command, string words = null, Item item = null)
        {
            // Set a foreground for this creature
            Console.ForegroundColor = ForegroundColor;

            // We need creature to interact with
            if (creature == null)
                throw new NullReferenceException("Crap");

            switch (command)
            {
                case Command.Eat:
                    throw new ArgumentException("Can't eat someone else, for now");
                    break;
                case Command.Talk:
                    // let's talk
                    MakeSound(creature, words);
                    break;
                case Command.Take:
                    // Take item from creature inventory to yourself
                    TakeItem(creature, item);
                    break;
                case Command.Kick:
                    creature.Weight -= KickPower.Next(0,9);
                    break;
                default:
                    throw new System.Exception("We need action!");
                    break;
            }
            // TODO: Think about interaction with itself

            // Reset console color to default
            Console.ResetColor();

            // A small pause to perform an action
            Thread.Sleep(1000);
        }

        /// <summary>
        /// Interact with a thing
        /// </summary>
        /// <param name="nonliving">A thing to interact with</param>
        /// <param name="command">What to do with a thing</param>
        public void PerformAction(Item item, Command command)
        {
            // Set a foreground for this creature
            Console.ForegroundColor = ForegroundColor;

            switch (command)
            {
                case Command.Eat:
                    EatFood(item);
                    break;
                case Command.Talk:
                    MakeSound("Why I'm talking to a thing?");
                    break;
                case Command.Take:
                    // If we have item...
                    if (item != null)
                        // take it
                        Inventory.Add(item);
                    else
                        // TODO: add some handler
                        MakeSound("There is no item to take");
                    break;
                case Command.Kick:
                    throw new System.NotImplementedException("Kick is not implemented");
                    break;
                default:
                    Console.WriteLine("You used unknown command, I don't know how");
                    break;
            }

            // A small pause to perform an action
            Thread.Sleep(1000);
        }

        /// <summary>
        /// Execute action that is out of the basic <see cref="Command"/>s.
        /// Action can't affect anything
        /// </summary>
        /// <param name="action">An action to execute</param>
        public void PerformComplicatedAction(string action)
        {
            // Set a foreground for this creature
            Console.ForegroundColor = ForegroundColor;

            // Execute action
            Console.WriteLine("{0} *{1}*", Name, action);

            // Reset console color to default
            Console.ResetColor();

            // A small pause to perform an action
            Thread.Sleep(1000);
        }

        /// <summary>
        /// Say something
        /// </summary>
        /// <param name="words">Words to say</param>
        public void MakeSound(string words = null)
        {
            // Change color of his words for this creature
            Console.ForegroundColor = ForegroundColor;

            // If we have nothing to say
            if (String.IsNullOrEmpty(words))
                // just make some noise
                Console.WriteLine("{0}: {1}", Name, Noise);
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
        public void MakeSound(Creature creature, string words = null)
        {
            // Change color of his words for this creature
            Console.ForegroundColor = ForegroundColor;

            // If this creature want to speak to itself
            if (creature == this)
            {
                // let it
                MakeSound(words);

                return;
            }

            // If we have nothing to say
            if (String.IsNullOrEmpty(words))
                // just make some noise, initiator considered way louder
                Console.WriteLine("{0} and {1}: {2}", Name, creature.Name, Noise);
            else
                // or say what a creature want to say
                Console.WriteLine("{0} and {1}: {2}", Name, creature.Name, words);

            // A small pause for words to say
            Thread.Sleep(1000);

            // Reset console color
            Console.ResetColor();
        }

        #endregion
    }
}
