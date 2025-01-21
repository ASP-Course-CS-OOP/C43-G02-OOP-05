using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Maths
    {

        #region Methods

        public static int Add(int a, int b) => a + b;
        public static int Subtract(int a, int b) => a - b;
        public static int Multiply(int a, int b) => a * b;
        public static int Divide(int a, int b) => b != 0 ? a / b : throw new DivideByZeroException("Division by zero is not allowed."); 
        
        #endregion

    }
}
