using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurClasses
{
    public class ChikFilA: IMilkshakable, IRestaurant
    {
        public DateTime OpeningTime { get; set; }
        public DateTime ClosingTime { get; set; }
        public Menu Menu { get; set; }
        public bool IsOpenOnSunday { get; set; }

        public Milkshake Shake(TypeOfFlavor flavor)
        {
            return new Milkshake()
            {
                Flavor = flavor
            };
        }
    }
}
