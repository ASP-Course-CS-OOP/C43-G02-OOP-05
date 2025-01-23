using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interface_Example_01
{
    internal interface IType 
    {
        // Default Access Modifiers Inside Interface => public.
        // private access modifiers is not allowed inside interface, why?
        // - Because The classes/Structs That will implemented this interface will not access those private members.

        // The default implemented method inside interface only can be private.
        // 
        //What you can write inside interface ?

        // 1- Signature for property
        public int MyProperty { get; set; }

        // 2- Signature for method
        public void MyMethod();

        // 3- Default Implemented Method [C# 8.0 Feature].
        public void Print()
        {
            Console.WriteLine("Default Implemented method!");
        }

        // 4- Static Members [Fields - Properties - Methods - Events]

    }
}
