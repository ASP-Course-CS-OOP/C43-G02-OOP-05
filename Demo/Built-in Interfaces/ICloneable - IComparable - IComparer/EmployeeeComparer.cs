using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Built_in_Interfaces.ICloneable___IComparable___IComparer
{
    internal class EmployeeeComparer : IComparer // Provide new Comparison behavior to the Type (Employee).
    {
        public int Compare(object? x, object? y)
        {
            Employeee? employeeX = (Employeee?)x;
            Employeee? employeeY = (Employeee?)y;
            return employeeX?.Id.CompareTo(employeeY?.Id) ?? (employeeY is null ? 0 : -1);
        }
    }
}
