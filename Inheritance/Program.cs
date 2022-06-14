using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class
            
            Bird Tweetie = new Bird();
            Tweetie.CloseToDinosaurs = true;
            Tweetie.LiveInPairs = true;
            Tweetie.HaveHollowBones = true;
            Tweetie.WarmBlooded = true;
            Tweetie.Sleeps = true;
            Tweetie.EatsFood = true;
            Tweetie.DrinksWater = true;
            Tweetie.MakesSound = "tweet";
            Console.WriteLine($"Tweetie is a close relative to Dinosaurs: {Tweetie.CloseToDinosaurs}");
            Console.WriteLine($"Tweetie would like to live with other birds: {Tweetie.LiveInPairs}");
            Console.WriteLine($"Tweetie has hollow bones: {Tweetie.HaveHollowBones}");
            Console.WriteLine($"Tweetiw is warm Blooded: {Tweetie.WarmBlooded}");
            Console.WriteLine($"Tweetie sleeps too much: {Tweetie.Sleeps}");
            Console.WriteLine($"Tweetie likes worms: {Tweetie.EatsFood}");
            Console.WriteLine($"Tweetie only drinks water: {Tweetie.DrinksWater}");
            Console.WriteLine($"Tweetie says {Tweetie.MakesSound}");
            Console.WriteLine();

            Reptile Slimy = new Reptile();
            Slimy.HasScales = true;
            Slimy.IsColdBlooded = true;
            Slimy.DoesNotSweat = true;
            Slimy.EatsFood = true;
            Slimy.DrinksWater = false;
            Slimy.Sleeps = true;
            Slimy.MakesSound = "sssssssss";
            Slimy.ReptileNoOneLikes = "Florida Gators";
            Console.WriteLine($"Slimy has scales: {Slimy.HasScales}");
            Console.WriteLine($"Slimy is cold blooded: {Slimy.IsColdBlooded}");
            Console.WriteLine($"Slimy does not sweat: {Slimy.DoesNotSweat}");
            Console.WriteLine($"Slimy eats sometimes: {Slimy.EatsFood}");
            Console.WriteLine($"Slimy does not driny any water: {Slimy.DrinksWater}");
            Console.WriteLine($"Slimy sleeps most the day: {Slimy.Sleeps}");
            Console.WriteLine($"Slimy says {Slimy.MakesSound}");
            Console.WriteLine($"A reptile that no one likes: The {Slimy.ReptileNoOneLikes}");

            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
        }
    }
}
