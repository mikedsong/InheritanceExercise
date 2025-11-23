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




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            Bird dodo = new Bird()
            {
                Name = "Dodo",
                Age = 6,
                Legs = 2,
                HasBackbone = true,
                IsWarmBlooded = true,
                HasFeathers = true,
                Wings = 2,
                Type = "flightless"
            };
            
            Console.WriteLine($"{dodo.Name} is a {dodo.Type} bird that is {dodo.Age} years old has {dodo.Legs} legs and {dodo.Wings} wings.");
            Console.WriteLine($"Is {dodo.Name} a vertebrate, warm blooded, and has feathers? " +
                              $"{dodo.HasBackbone}, {dodo.IsWarmBlooded}, and {dodo.HasFeathers}.");
            Console.WriteLine();

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *
             * Creatively display the class member values
             */
            Reptile dinosaur = new Reptile()
            {
                Name = "Reptar",
                Age = 4,
                Legs = 2,
                HasBackbone = true,
                IsColdBlooded = true,
                HasScales = true,
                Environment = "Tommy's house",
                Defense = "Poke Feet"

            };
            
            Console.WriteLine($"{dinosaur.Name} is a {dinosaur.Age} year old dragon that lives under {dinosaur.Environment}, {dinosaur.Defense}, and has {dinosaur.Legs} legs ");
            Console.WriteLine($"Is {dinosaur.Name} a vertebrate, cold blooded, and has scales? {dinosaur.HasBackbone}, {dinosaur.IsColdBlooded}, and {dinosaur.HasScales}.");
            Console.WriteLine();

        }
    }
}
