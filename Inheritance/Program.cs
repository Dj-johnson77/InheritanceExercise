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
            // DONE!

            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class
            // DONE!

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class
            // DONE!



            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            var parakeet = new Bird();
            parakeet.canFly = true;
            parakeet.wings = 2;
            parakeet.hasBeak = true;
            parakeet.species = "budgie";

            Console.WriteLine("BIRD:");
            Console.WriteLine("");
            Console.WriteLine($"Bird's species = {parakeet.species}");
            Console.WriteLine($"Ability to fly = {parakeet.canFly}");
            Console.WriteLine($"Number of funcational wings = {parakeet.wings}");
            Console.WriteLine($"Small beak = {parakeet.hasBeak}");
            Console.WriteLine("");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("");

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            var lizard = new Reptile();
            lizard.isMale = true;
            lizard.dinosaurLike = true;
            lizard.isColdBlooded = true;
            lizard.species = "Iguana";
            
            Console.WriteLine("REPTILE:");
            Console.WriteLine("");
            Console.WriteLine($"Lizard species = {lizard.species}");
            Console.WriteLine($"Male = {lizard.isMale}");
            Console.WriteLine($"Prehistoric aesthetic = {lizard.dinosaurLike}");
            Console.WriteLine($"Cold blooded = {lizard.isColdBlooded}");








            
        }
    }
}
