using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OurClasses;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IMilkshakable> milkList = new List<IMilkshakable>();
            for (int i = 0; i < 500; i++)
            {
                IMilkshakable cfa = new ChikFilA();
                IMilkshakable bk = new BurgerKing();
                milkList.Add(cfa);
                milkList.Add(bk);
            }
            // later in the solution
            foreach (IMilkshakable msb in milkList)
            {
                TypeOfFlavor f = Customer.GetRandomFlavor();
                Milkshake ms1 = msb.Shake(f);
                string restaurantType = msb.GetType().Name;
                // Console.WriteLine(restaurantType + ": " +  ms1.Drink());
                Console.WriteLine(String.Format("{0} : {1}", restaurantType, ms1.Drink()));
            }
            Console.ReadKey(true);
        }
    }
}
