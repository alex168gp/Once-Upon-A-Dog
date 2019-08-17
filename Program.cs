using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;

namespace Once_Upon_A_Dog
{
    class Program
    {
        // A shortcut
        delegate void NarratorWordsDelegate(string words = null);

        delegate void CharacterWordsDelegate(Creature creature, string words = null, int repeat = 1);


        #region Main

        static void Main(string[] args)
        {
            // Start a story
            Storyboard storyboard = new Storyboard();

            // A shortcut
            NarratorWordsDelegate narrator = Storyboard.NarratorWords;
            CharacterWordsDelegate characterWords = CharacterWords;

            #region All characters

            Dog dog = new Dog("Old dog", 2);
            // TODO: Manage inventory to expand the story and scene
            Human father = new Human("Father", 6);
            Human mother = new Human("Mother", 3);
            Human daughter = new Human("Daughter", 3);
            Creature son = new Creature("Baby", 1);
            Creature crowd = new Creature("Crowd in a distance", 10);
            Wolf wolf = new Wolf("Old wolf", 2);
            Creature crowdInHouse = new Creature("People at the wedding", 1);

            #endregion

            #region Manual Testing
            /*
            storyboard.NewPage();
            Creature test = new Creature("Test subject", 9);
            Item testItem1 = new Item("Test item 1", 9);
            Item testItem2 = new Item("Test item 2", 1);
            storyboard.FieldItems.Add(testItem1);
            storyboard.FieldItems.Add(testItem1);
            storyboard.FieldItems.Add(testItem1);
            storyboard.FieldItems.Add(testItem1);
            storyboard.FieldItems.Add(testItem1);
            //storyboard.FieldItems[0].Weight = 0;
            var f = storyboard.FieldItems;
            //testItem1.Weight = 0;
            //f.Remove(testItem1);
            //var test = storyboard.FieldItems[0];
            //storyboard.FieldItems[0].Weight = 0;
            //storyboard.FieldItems.Add(testItem2);
            //wolf.PerformAction(test, Command.Talk);
            //storyboard.FieldItems[0].Weight = -1;
            //storyboard.NewPage();
            
            
            while (!wolf.IsFull)
            {
                if (wolf.Weight >= 8)
                    characterWords(wolf, "I'll sing right now.");

                // TODO: Add different food
                // TODO: Change messages
                try
                {
                    crowdInHouse.PerformAction(storyboard.FieldItems.First(item => item.IsFood), Command.Eat);
                    wolf.PerformAction(storyboard.FieldItems.First((Item item) =>
                    {
                        return item.IsFood;
                    }
                    ), Command.Eat);
                }
                catch (Exception)
                {
                    Console.WriteLine("No more items on a field!");
                    characterWords(wolf, "I'll sing right now.");
                    wolf.IsFull = true;
                }
            }
            */
            #endregion

            #region Original Story

            // TODO: Create a storyboard for text, and change all MakeSound implementations to fit
            // TODO: Create a scene where all objects will be connected
            // TODO: Add interactivity

            // First scene
            narrator("Morning.");
            narrator("You can see a bunch of small white thatched houses.");
            // TODO: Add more animals, maybe
            narrator("Somewhere a rooster greets the rising sun.");
            narrator("-------------------------------------------------------------------------");
            narrator("In a small village lived old dog.");
            characterWords(dog, repeat: 2);
            narrator("His owners were a family of 4: father, mother, daughter and baby son.");
            narrator("Old dog caused a lot of small troubles, but he was always forgiven.");
            narrator("Father and mother with baby left to sell some goods.");
            narrator("--------------------------------------------------------------------------");
            narrator("Evening.");
            narrator("Daughter has gone with her boyfriend for a little walk and sang.");
            // TODO: Review all PerformComplicatedAction
            daughter.PerformComplicatedAction("Sings");
            narrator("While everyone from a family were gone, a thief came to their house.");
            narrator("Even though he was making a lot of sound, old dog didn't hear him.");
            characterWords(dog);
            narrator("--------------------------------------------------------------------------");
            narrator("Morning.");
            narrator("Owners came back.");
            daughter.PerformAction(mother, Command.Talk);
            son.MakeSound();
            narrator("And kicked the old dog from house.");

            // Second scene
            // TODO: Add time handler for a fluent storytelling
            storyboard.NewPage();
            narrator("He run and run.");
            narrator("And come to a forest.");
            dog.PerformComplicatedAction("Rumbling stomach");
            narrator("He tried to hunt something, but in the end of a day he had no choice as to eat some roots.");
            crowd.PerformComplicatedAction("Sings");
            dog.PerformComplicatedAction("Cries");
            dog.PerformComplicatedAction("Spotted a nice thick branch for a rope");
            dog.PerformComplicatedAction("Started to swing a rope");
            characterWords(wolf, "God help?");
            characterWords(wolf, "Are you climbing trees?");
            characterWords(dog, "Well, I, wanted to catch a bird.");
            characterWords(wolf, "Yeah");
            characterWords(dog, "Well, you know, I was walking...");
            dog.PerformComplicatedAction("Hides the rope behind");
            characterWords(wolf, "Yeah");
            dog.PerformComplicatedAction("Stomach rumbling");
            characterWords(wolf, "Did they kicked you out?");
            dog.PerformComplicatedAction("Makes a sad face");

            // Third scene
            storyboard.NewPage();
            wolf.PerformComplicatedAction("Walks around");
            characterWords(wolf, "Do you remember how you chased me before?");
            characterWords(dog, "Well, you know...");
            characterWords(wolf, "Yeah, it was your job.");
            wolf.PerformComplicatedAction("Sits on a stump");
            characterWords(wolf, "All my life I live here, and no one gives me even a small bone.");
            characterWords(dog, "Well, you know...");
            crowd.PerformComplicatedAction("Sing");
            characterWords(wolf, "Now you're like me muahaha, AHAHAHA HUH");
            wolf.PerformComplicatedAction("Hurt his back");
            characterWords(wolf, "Ooooh");
            narrator("While crowd sang until it's late, wolf and dog found a good place to watch the moon.");
            wolf.PerformAction(dog, Command.Talk, "~Awooooo");

            // Fourth scene
            storyboard.NewPage();
            narrator("Somewhere in the midday.");
            narrator("All family work on a field, mowing the wheat.");
            son.MakeSound();
            narrator("A wolf appeared out of nowhere, and took a baby.");
            daughter.PerformAction(mother, Command.Talk);
            father.PerformComplicatedAction("Tries to chase but he's too slow");
            son.MakeSound();
            son.PerformComplicatedAction("Playing with a wolf head");
            dog.PerformComplicatedAction("Appears from a bush");
            characterWords(dog, repeat: 3);
            dog.PerformComplicatedAction($"Starts a fight with {wolf.Name}");
            wolf.PerformComplicatedAction("Drops a baby");
            father.PerformComplicatedAction("Hides behind a bush and just watch");
            characterWords(dog, "Did you hurt him?");
            characterWords(wolf, "What can happen to him?");
            characterWords(dog, "Well, goodbye");
            wolf.PerformComplicatedAction("Runs away");
            father.PerformComplicatedAction("Runs behind a dog");
            dog.PerformComplicatedAction("Runs with a baby");
            mother.PerformAction(daughter, Command.Talk);
            dog.PerformComplicatedAction("Comes with a baby");
            wolf.PerformComplicatedAction("Watching behind some bushes");
            son.MakeSound();
            narrator("Everyone happy");

            // Last scene
            storyboard.NewPage();

            narrator("Winter.");
            narrator("A family decided to arrange a wedding for their daughter, the whole village and their relatives gathered in the house.");
            narrator("After the accident with a baby, old dog started to live like before, and even better.");
            narrator("Everything bad was forgotten.");
            characterWords(wolf, repeat: 2);
            narrator("Dog run into the forest.");
            narrator("He found his friend wolf on a stump, shivering from cold and howling.");
            dog.PerformComplicatedAction("Breathing hard");
            characterWords(dog, "Well, I...");
            characterWords(wolf, "What?! Again?");
            characterWords(dog, "No. You want to eat?");
            crowdInHouse.PerformComplicatedAction("Dancing, singing, eating and drinking");
            Thread.Sleep(3000);
            dog.PerformComplicatedAction($"Sitting under the table with {wolf.Name}");
            // Wolf start to eat
            while (!wolf.IsFull)
            {
                if (wolf.Weight == 8)
                    characterWords(wolf, "I'll sing right now.");

                // TODO: Add different food
                // TODO: Change messages
                try
                {
                    // LINQ
                    crowdInHouse.PerformAction(storyboard.FieldItems.First(item => item.IsFood), Command.Eat);
                    // Anonymous method
                    wolf.PerformAction(storyboard.FieldItems.First((Item item) =>
                    {
                        return item.IsFood;
                    }
                    ), Command.Eat);
                }
                catch (Exception)
                {
                    Console.WriteLine("No more items on a field!");
                    characterWords(wolf, "I'll sing right now.");
                    wolf.IsFull = true;
                }
            }
            crowdInHouse.PerformComplicatedAction("Everyone is sitting at the table and start to sing");
            characterWords(wolf, "I'll sing right now for sure.");
            characterWords(wolf);
            crowdInHouse.PerformComplicatedAction("Stops singing");
            crowdInHouse.MakeSound();
            narrator("Some try to run, some took something to defend themselves. Old dog tries to chase away wolf.");
            characterWords(dog, "Well, you know...");
            characterWords(wolf, "Thank you.");
            characterWords(dog, "Ah...");
            wolf.PerformComplicatedAction("Breaks a fence");
            characterWords(wolf, "You can come, anytime.");
            narrator("The end.");

            #endregion

            storyboard.NewPage();
        }

        #endregion

        #region Helpers

        static void CharacterWords<T>(T creature, string words = null, int repeat = 1)
            where T : Creature
        {
            creature.MakeSound(words, repeat);
        }

        #endregion
    }
}
