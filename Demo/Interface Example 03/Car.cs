using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interface_Example_03
{
    internal class Car : Vechile, IMovable // "Car" is a "Vechile" and can do "MoveOnGround" behavior.
    {
        public void Forward()
        {
            Console.WriteLine("Car move forward on ground!");
        }

        public void Backward()
        {
            Console.WriteLine("Car move backward on ground!"); 
        }

        public void Left()
        {
            Console.WriteLine("Car move left on ground!");
        }

        public void Right()
        {
            Console.WriteLine("Car move right on ground!");
        }
    }
}
