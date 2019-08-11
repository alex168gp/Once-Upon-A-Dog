using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading;

namespace Once_Upon_A_Dog
{
    /// <summary>
    /// Handles various aspects of a storyboard such as narrator text, moving to a next scene,
    /// what items and characters present on a scene
    /// </summary>
    public class Storyboard
    {
        #region Private Members

        /// <summary>
        /// A field that allows to get random number that should be used for item generation
        /// </summary>
        private Random ItemGenerator = new Random();

        /// <summary>
        /// A field that allows to get random number that should be used for weight generation
        /// </summary>
        private Random WeightGenerator = new Random();

        #endregion

        #region Public Members

        /// <summary>
        /// A list of items in a current scene that are not in the inventory of characters
        /// </summary>
        public ObservableCollection<Item> FieldItems = new ObservableCollection<Item>();

        /// <summary>
        /// A list of characters in a current scene
        /// </summary>
        public List<Creature> Characters = new List<Creature>();

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public Storyboard()
        {
            // Hook event
            FieldItems.CollectionChanged += FieldItems_CollectionChanged;

            Console.ForegroundColor = ConsoleColor.Green;

            // Title of a story
            Console.WriteLine("Once upon a dog");

            Console.ResetColor();
        } 

        #endregion

        #region Private Methods

        /// <summary>
        /// Adds random amount of food to a scene
        /// </summary>
        private void foodGenerator(int min = 2, int max = 10)
        {
            // Minimum value for itemGenerator can't be lower than 2
            if (min < 2)
                throw new ArgumentException("min should be higher than 2!");

            // Add random amount of food to a scene with a random weight
            for (int i = 0; i < ItemGenerator.Next(min, max); i++)
                FieldItems.Add(new Item("Food", WeightGenerator.Next(1, 3), isFood: true));
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// After pressing any key clears all items and text of a current scene.
        /// After the story continues which means a new scene created.
        /// </summary>
        public void NewPage()
        {
            // A pause before page refresh
            Console.ReadKey();

            // TODO: Try async?
            // Clears all items that are not carried by characters
            FieldItems.Clear();

            // Clear console screen
            Console.Clear();

            // Add more and new food
            foodGenerator();
        } 

        /// <summary>
        /// Show narrator lines in console
        /// </summary>
        /// <param name="words">Narrator words to say</param>
        public static void NarratorWords(string words)
        {
            // Check for null
            if (String.IsNullOrEmpty(words))
                throw new ArgumentNullException("Narrator should say something. He's been paid, and paid well.");

            // Reset color of a console typing
            Console.ResetColor();

            // Show narrator lines in console
            Console.WriteLine(words);

            // A little pause to read narrator text
            Thread.Sleep(1000);
        }

        // TODO: Check all events
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FieldItems_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            if (e.OldItems != null)
            {
                foreach (Item item in e.OldItems)
                {
                    //Console.WriteLine(item.Name + "destroyed");
                    item.PropertyChanged -= Item_PropertyChanged;
                }
            }
            if (e.NewItems != null)
            {
                foreach (Item item in e.NewItems)
                {
                    //Console.WriteLine(item.Name + "added");
                    item.PropertyChanged += Item_PropertyChanged;
                }
            }
        }

        /// <summary>
        /// An event for <see cref="Item.Weight"/> property, when the value to set is lower or equal than 0
        /// </summary>
        /// <param name="sender">Item</param>
        /// <param name="e"></param>
        private void Item_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            //Console.WriteLine($"{(sender as Item).Name} Will be destroyed");
            FieldItems.Remove((sender as Item));
        }

        #endregion
    }
}
