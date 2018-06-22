using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurClasses
{
    public static class Customer
    {
        // This will return a random milkshake flavor
        public static TypeOfFlavor GetRandomFlavor()
        {
            Random r = new Random();
            int randomNumber = r.Next(1, 4);
            TypeOfFlavor castedResult = (TypeOfFlavor)randomNumber;
            return castedResult;
            // return (TypeOfFlavor)new Random().Next(4);
        }

    }
}
