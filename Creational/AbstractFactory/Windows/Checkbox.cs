using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.AbstractFactory.Windows
{
    internal class Checkbox : IGuiElement
    {
        public void Render()
        {
            Console.WriteLine("Rendering Checkbox on Windows");
        }
    }
}
