using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurClasses
{
    public interface IMilkshakable
    {
        Milkshake Shake(TypeOfFlavor flavor);
    }
}
