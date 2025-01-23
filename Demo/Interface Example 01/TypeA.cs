using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interface_Example_01
{
    internal class TypeA : IType
    {
        private int MyAttribute;
        public int MyProperty
        {
            get { return MyAttribute; }
            set { MyAttribute = value; }
        }

        public void MyMethod()
        {
            Console.WriteLine("Hello, World!");
        }

    }
}
