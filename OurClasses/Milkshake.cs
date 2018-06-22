using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurClasses
{
    public class Milkshake
    {
        public TypeOfFlavor Flavor { get; set; }
        public string Drink()
        {
            // return "Yum - that was a great " + Flavor + " milkshake!";
            var hatedFlavor = anotherFlavor();
            return String.Format("Yum - that was a great {0} milkshake - I hate {1} milkshakes!", 
                Flavor, hatedFlavor);
        }

        private TypeOfFlavor anotherFlavor()
        {
            if (Flavor != TypeOfFlavor.Chocolate)
                return TypeOfFlavor.Chocolate;
            if (Flavor != TypeOfFlavor.Vanilla) 
                return TypeOfFlavor.Vanilla;
            return TypeOfFlavor.Strawberry; // never going to happen, trust me!
        }
    }
}
