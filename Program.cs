using System;
using System.Threading;

namespace Once_Upon_A_Dog
{
    class Program
    {
        #region Main

        static void Main(string[] args)
        {
            // TODO: Create a storyboard for text, and change all MakeSound implementations to fit
            // TODO: Create a scene where all objects will be connected
            // TODO: Add interactivity
            // TODO: Think about narrator class
            Creature narrator = new Creature("Narrator", 0);
            // First scene
            narrator.MakeSound("Once upon a dog.");
            narrator.MakeSound("Morning.");
            narrator.MakeSound("You can see a bunch of small white thatched houses.");
            // TODO: Add more animals
            narrator.MakeSound("Somewhere a cock greets the rising sun.");
            Console.WriteLine("-------------------------------------------------------------------------");
            narrator.MakeSound("In a small village lived old dog.");
            Dog dog = new Dog("Old dog", 2);
            dog.MakeSound("");
            dog.MakeSound("");
            dog.MakeSound("");
            narrator.MakeSound("His owners were a family of 4: father, mother, daughter and baby son.");
            Human father = new Human("Father", 6);
            Human mother = new Human("Mother", 3);
            Human daughter = new Human("Daughter", 3);
            Creature son = new Creature("Baby", 1);
            // TODO: Manage inventory to expand the story and scene
            narrator.MakeSound("Old dog caused a lot of small troubles, but he was always forgiven.");
            narrator.MakeSound("Father and mother with baby left to sell some goods.");
            Console.WriteLine("--------------------------------------------------------------------------");
            narrator.MakeSound("Evening.");
            narrator.MakeSound("Daughter has gone with her boyfriend for a little walk and sang.");
            // TODO: Move complicated actions
            daughter.MakeSound("*A song*");
            narrator.MakeSound("While everyone from a family were gone, a thief came to their house.");
            narrator.MakeSound("Even though he was making a lot of sound, old dog didn't hear him.");
            dog.MakeSound("");
            Console.WriteLine("--------------------------------------------------------------------------");
            narrator.MakeSound("Morning.");
            narrator.MakeSound("Owners came back.");
            daughter.MakeSound("");
            mother.MakeSound("");
            son.MakeSound("");
            narrator.MakeSound("And kicked the old dog from house.");
            // Second scene
            // TODO: Add time handler for a fluent storytelling
            NewPage();
            narrator.MakeSound("He run and run.");
            narrator.MakeSound("And come to a forest.");
            dog.MakeSound("*Stomach rumbling*");
            narrator.MakeSound("He tried to hunt something, but in the end of a day he had no choice as to eat some roots.");
            Creature crowd = new Creature("Crowd in a distance", 10);
            crowd.MakeSound("*A song*");
            dog.MakeSound("*Cries*");
            dog.MakeSound("*Spotted a nice thick branch for a rope*");
            dog.MakeSound("*Started to swing a rope*");
            Wolf wolf = new Wolf("Old wolf", 2);
            wolf.MakeSound("God help?");
            wolf.MakeSound("Are you climbing trees?");
            dog.MakeSound("Well, I, wanted to catch a bird.");
            wolf.MakeSound("Yeah");
            dog.MakeSound("Well, you know, I was walking...");
            dog.MakeSound("*Hides the rope behind*");
            wolf.MakeSound("Yeah");
            dog.MakeSound("*Stomach rumbling*");
            wolf.MakeSound("Did they kicked you out?");
            dog.MakeSound("*Makes a sad face*");
            // Third scene
            NewPage();
            wolf.MakeSound("*Walks around*");
            wolf.MakeSound("Do you remember how you chased me before?");
            dog.MakeSound("Well, you know...");
            wolf.MakeSound("Yeah, it was your job.");
            wolf.MakeSound("*Sits on a stump*");
            wolf.MakeSound("All my life I live here, and no one gives me even a small bone.");
            dog.MakeSound("Well, you know...");
            crowd.MakeSound("*A song*");
            wolf.MakeSound("Now you're like me muahaha, AHAHAHA HUH");
            wolf.MakeSound("*Hurt his back*");
            wolf.MakeSound("Ooooh");
            narrator.MakeSound("While crowd sing until it's late, wolf and dog found a good place to watch the moon.");
            wolf.MakeSound("");
            dog.MakeSound("");
            dog.MakeSound("");
            wolf.MakeSound("");
            dog.MakeSound("");
            dog.MakeSound("");
            // Fourth scene
            NewPage();
            narrator.MakeSound("Somewhere in the midday.");
            narrator.MakeSound("All family work on a field, mowing the wheat.");
            son.MakeSound("");
            narrator.MakeSound("A wolf appeared out of nowhere, and took a baby.");
            mother.MakeSound("");
            daughter.MakeSound("");
            father.MakeSound("*Tries to chase but he's too slow*");
            son.MakeSound("");
            son.MakeSound("*Playing with a wolf head*");
            dog.MakeSound("*Appears from a bush*");
            dog.MakeSound("");
            dog.MakeSound("");
            dog.MakeSound("");
            dog.ExecuteAction(wolf, Command.Talk, "*Starts a fight*");
            wolf.MakeSound("*Drops a baby*");
            father.MakeSound("*Hides behind a bush and just watch*");
            dog.MakeSound("Did you hurt him?");
            wolf.MakeSound("What can happen to him?");
            dog.MakeSound("Well, goodbye");
            wolf.MakeSound("*Runs away*");
            father.MakeSound("*Runs behind a dog*");
            dog.MakeSound("*Runs with a baby*");
            mother.MakeSound("");
            daughter.MakeSound("");
            dog.MakeSound("*Comes with a baby*");
            wolf.MakeSound("*Watching behind some bushes*");
            son.MakeSound("");
            narrator.MakeSound("Everyone happy");
            // Last scene
            NewPage();
            narrator.MakeSound("Winter.");
            narrator.MakeSound("A family decided to arrange a wedding for their daughter, the whole village and their relatives gathered in the house.");
            narrator.MakeSound("After the accident with a baby, old dog started to live like before, and even better.");
            narrator.MakeSound("Everything bad was forgotten.");
            Creature crowdInHouse = new Creature("People at the wedding", 10);
            wolf.MakeSound("");
            wolf.MakeSound("");
            narrator.MakeSound("Dog run into the forest.");
            narrator.MakeSound("He found his friend wolf on a stump, shivering from cold and howling.");
            dog.MakeSound("Well, I...");
            dog.MakeSound("*Breathing hard*");
            wolf.MakeSound("What?! Again?");
            dog.MakeSound("No. You want to eat?");
            crowdInHouse.MakeSound("*Dancing, singing, eating and drinking*");
            Thread.Sleep(3000);
            dog.ExecuteAction(wolf, Command.Talk, "*Sitting under the table*");
            // Wolf start to eat
            while(!wolf.IsFull)
            {
                if (wolf.Weight == 8)
                    wolf.MakeSound("I'll sing right now.");
                
                // TODO: Add different food
                wolf.ExecuteAction(new Item("Food", 2, isFood: true), Command.Eat);
            }
            crowdInHouse.MakeSound("*Everyone is sitting at the table and start to sing*");
            wolf.MakeSound("I'll sing right now for sure.");
            wolf.MakeSound("");
            crowdInHouse.MakeSound("*Stops singing*");
            crowdInHouse.MakeSound("");
            narrator.MakeSound("Some try to run, some took something to defend themselves. Old dog tries to chase away wolf.");
            dog.MakeSound("Well, you know...");
            wolf.MakeSound("Thank you.");
            dog.MakeSound("Ah...");
            wolf.MakeSound("*Breaks a fence*");
            wolf.MakeSound("You can come, anytime.");
            narrator.MakeSound("The end.");
            Console.ReadKey();
        }

        #endregion

        #region Static Helpers

        /// <summary>
        /// Allows to read story, and after some fixed time (10 sec) clears all text.
        /// After the story continues
        /// </summary>
        static void NewPage()
        {
            // A pause for 10 seconds
            Thread.Sleep(10000);

            // Clear console screen
            Console.Clear();
        }

        #endregion
    }
}
