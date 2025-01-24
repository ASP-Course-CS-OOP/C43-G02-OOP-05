using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interface_Example_03
{
    // Implement the interfaces [IMovable - IFlyable] implicitly => if the implementation of behaviors/methods of (IMovable & IFlyable) inside the "Airplane" class is the same implementation
    // - mean that the "Airplane" move on ground and sky in the same way.
    internal class Airplane01 : Vechile, IMovable, IFlyable
    {
        public void Forward()
        {
            Console.WriteLine("Airplane move forward!");
        }

        public void Backward()
        {
            Console.WriteLine("Airplane move backward!");
        }

        public void Left()
        {
            Console.WriteLine("Airplane move left!");
        }

        public void Right()
        {
            Console.WriteLine("Airplane move right!");
        }
    }

    // Implement the Interfaces [IMovable - IFlyable] Explicitly => if the implementation of behaviors/methods of (IMovable & IFlyable) inside the "Airplane" class is different from each other
    // - mean that the "Airplane" move on ground in specific way and move on sky in the another way.
    internal class Airplane02 : Vechile, IMovable, IFlyable
    {
        void IFlyable.Backward()
        {
            Console.WriteLine("Airplane move backward on sky!");
        }

        void IMovable.Backward()
        {
            Console.WriteLine("Airplane move backward on ground!");
        }

        void IFlyable.Forward()
        {
            Console.WriteLine("Airplane move backward on sky!");
        }

        void IMovable.Forward()
        {
            Console.WriteLine("Airplane move forward on ground!");
        }

        void IFlyable.Left()
        {
            Console.WriteLine("Airplane move left on sky!");
        }

        void IMovable.Left()
        {
            Console.WriteLine("Airplane move left on ground!");
        }

        void IFlyable.Right()
        {
            Console.WriteLine("Airplane move right on sky!");
        }

        void IMovable.Right()
        {
            Console.WriteLine("Airplane move right on ground!");
        }
    }
}
