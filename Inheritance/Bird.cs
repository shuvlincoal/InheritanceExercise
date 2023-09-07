using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Bird : Animal
    {
        public bool  Predator { get; set; }
        public bool Sings    { get; set; }
        public bool MakeNest { get; set; }
        public bool Nocturnal { get; set; }


        public void ViewBird(Bird myBird)
        {
            Console.WriteLine($"Your Animsal Characteristics:");
            Console.WriteLine($"Does Bird Make Nest: {myBird.MakeNest}");
            Console.WriteLine($"Does Bird sing:      {myBird.Sings}");
            Console.WriteLine($"Does Bird Make Nest: {myBird.MakeNest}");
            Console.WriteLine($"Is Bird a predator:  {myBird.Predator}");

            Console.WriteLine($"Animal Type:         {myBird.Type}");
            Console.WriteLine($"Is Bird Dangerous:   {myBird.Dangerous}");
            Console.WriteLine($"Press Return To Continue:");
            Console.ReadLine();
        }

    }



}
