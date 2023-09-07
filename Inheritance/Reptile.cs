using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Reptile : Animal
    {
        public bool  Venomous      { get; set; }
        public bool LiveInTrees   { get; set; }
        public bool LiveOnGround  { get; set; }
        public bool LivesInWater  { get; set; }

        public  void ViewReptile(Reptile myReptile)
        {
            Console.WriteLine($"Your Animsal Characteristics:");
            Console.WriteLine($"Reptile is Venomous:    {myReptile.Venomous}");
            Console.WriteLine($"Reptile Live Trees:     {myReptile.LiveInTrees}");
            Console.WriteLine($"Reptile Live on Ground: {myReptile.LiveOnGround}");
            Console.WriteLine($"Reptile Live in Water:  {myReptile.LivesInWater}");

            Console.WriteLine($"Animal Type:            {myReptile.Type}");
            Console.WriteLine($"Is Animal Dangerous:    {myReptile.Dangerous}");
            Console.WriteLine($"Press Return To Continue:");
            Console.ReadLine();
        }
    }
}
