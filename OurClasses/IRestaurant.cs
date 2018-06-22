using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurClasses
{
    public interface IRestaurant
    {
        DateTime OpeningTime { get; set; }
        DateTime ClosingTime { get; set; }
        Menu Menu { get; set; }
    }
}
