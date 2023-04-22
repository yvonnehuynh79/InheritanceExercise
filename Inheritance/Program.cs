using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Done Create a class Animal 
            // Done give this class 4 members that all Animals have in common


            // Done Create a class Bird
            // Done give this class 4 members that are specific to Bird
            // Done Set this class to inherit from your Animal Class

            // DoneCreate a class Reptile
            // Donegive this class 4 members that are specific to Reptile
            // Done Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             * 
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */


            Bird bird = new Bird();
            bird.CanFly = true;
            bird.CanSing = true;
            bird.HasBeak = true;
            bird.HasTwoLegs = 2;




            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            Reptile snake = new Reptile();
            snake.LaysEggs = true;
            snake.IsColdBlooded = true;
            snake.HasScales = true;
            snake.HasMouth = true;

            Animal[] array = new Animal[] { bird, snake };

            array[0] = bird;
            array[1] = snake;

            foreach (var item in array)
            {
                Console.WriteLine(item.GetType());
                Console.WriteLine($"is {item.Age} years old");
                Console.WriteLine($"has {item.LegCount} legs");
                Console.WriteLine($"can walk {item.CanWalk}");
                Console.WriteLine($"eats {item.EatsFood}");
                Console.WriteLine();
            }




        }
    }
}
    
