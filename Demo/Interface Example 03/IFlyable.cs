using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interface_Example_03
{
    internal interface IFlyable // Represent Methods/Behaviors of move on Sky.
    {
        public void Forward();
        public void Backward();
        public void Left();
        public void Right();
    }
}
