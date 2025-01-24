using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interface_Example_03
{
    internal interface IMovable // Represent Methods/Behaviors of move on ground
    {
        public void Forward();
        public void Backward();
        public void Left();
        public void Right();
    }
}
