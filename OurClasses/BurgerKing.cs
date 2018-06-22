using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurClasses
{
    public class BurgerKing: IRestaurant, IMilkshakable
    {
        public static void Close()
        {
            // close the doors at ClosingTime
        }

        public DateTime OpeningTime { get; set; }
        public DateTime ClosingTime { get; set; }
        public Menu Menu { get; set; }

        public Milkshake Shake(TypeOfFlavor flavor)
        {
            return new Milkshake()
            {
                Flavor = TypeOfFlavor.Chocolate
            };
        }
    }
}
