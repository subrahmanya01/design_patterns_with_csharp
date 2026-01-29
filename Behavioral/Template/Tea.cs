using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioural.Template
{
    internal class Tea : CaffineBeverage
    {
        public override void AddIngrediants()
        {
            Console.WriteLine("Adding Milk....");
            Console.WriteLine("Adding Tea Powder...");
        }
    }
}
