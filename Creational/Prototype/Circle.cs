using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Prototype
{
    internal class Circle : Shape
    {
        public Circle(int id) : base(id)
        {
        }

        public override Shape Clone()
        {
            return new Circle(_id);
        }
    }
}
