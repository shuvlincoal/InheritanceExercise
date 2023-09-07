using System;
using System.IO;

namespace Inheritance
{
    class Program
    {








        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal [done]
            // give this class 4 members that all Animals have in common


            // Create a class Bird [done]
            // give this class 4 members (characteristics) that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile [done]
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class

            Bird    myBird    = new Bird();
            myBird.Type      = "Bird";
            myBird.Dangerous = false;

            myBird.Predator = true;
            myBird.Sings = true;
            myBird.MakeNest = true;
            myBird.Nocturnal = true;


            Reptile myReptile = new Reptile();
            myBird.Type = "Comodo Dragon";
            myBird.Dangerous = true;

            myReptile.Venomous = true;
            myReptile.LiveInTrees = false;
            myReptile.LiveOnGround = true;
            myReptile.LivesInWater = true;


            /*Create an object (instance) of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            myBird.ViewBird(myBird);

            myReptile.ViewReptile(myReptile);


            /*Create an object (instance) of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
        }
    }
}
