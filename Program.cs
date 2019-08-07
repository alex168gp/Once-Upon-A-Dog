using System;
using System.Threading;

namespace Once_Upon_A_Dog
{
    class Program
    {
        #region Main

        static void Main(string[] args)
        {
            // TODO: Create a scene where all objects will be connected, and add interactivity
            // TODO: Think about narrator class
            Creature narrator = new Creature("Narrator", 0);
            narrator.MakeSound("Once upon a dog.");
            narrator.MakeSound("Morning.");
            narrator.MakeSound("You can see a bunch of small white thatched houses.");
            // TODO: Add more animals
            narrator.MakeSound("Somewhere a cock greets the rising sun.");
            narrator.MakeSound("------------------------------------------------------------------");
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
            narrator.MakeSound("Old dog caused a lot of small troubles, but he was always forgiven.");
            narrator.MakeSound("Father and mother with baby left to sell some goods.");
            narrator.MakeSound("-----------------------------------------------------------------");
            narrator.MakeSound("Evening.");
            narrator.MakeSound("Daughter has gone with her boyfriend for a little walk and sang.");
            daughter.MakeSound("*Some song I'm too lazy to search*");
            narrator.MakeSound("While everyone from a family were gone, a thief came to their house.");
            narrator.MakeSound("Even though he was making a lot of sound, old dog didn't hear him.");
            dog.MakeSound("");
            narrator.MakeSound("------------------------------------------------------------------");
            narrator.MakeSound("Morning.");
            narrator.MakeSound("Owners came back.");
            daughter.MakeSound("");
            mother.MakeSound("");
            son.MakeSound("");
            narrator.MakeSound("And kicked the old dog from house.");
            // TODO: Add some time handler
            Thread.Sleep(10000);
            Console.Clear();
            narrator.MakeSound("He run and run.");
            narrator.MakeSound("And come to a forest.");
            dog.MakeSound("*Sounds of hunger*");
            narrator.MakeSound("He tried to hunt something, but in the end of a day he had no choice as to eat some roots.");
            Creature crowd = new Creature("Crowd in a distance", 10);
            crowd.MakeSound("*A song*");
            dog.MakeSound("*Cry*");
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
            dog.MakeSound("*Sounds of hunger*");
            wolf.MakeSound("Did they kicked you out?");
            dog.MakeSound("*Makes sad face*");
            Thread.Sleep(10000);
            Console.Clear();
            wolf.MakeSound("*Walk around*");
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
            Console.ReadKey();
        } 

        #endregion
    }
}
