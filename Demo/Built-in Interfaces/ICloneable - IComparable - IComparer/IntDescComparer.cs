using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Built_in_Interfaces.ICloneable___IComparable___IComparer
{
    internal class IntDescComparer : IComparer // Sorting Array of integers Desc.
    {

        #region Methods
        
        public int Compare(object? x, object? y)
        {

            int? X = (int?)x;
            int? Y = (int?)y;

            return ((X is null && y is null) ? 0 : (X is null) ? -1 : (Y is null) ? 1 : (X.Value > Y.Value) ? -1 : (X.Value < Y.Value) ? 1 : 0);

        } 

        #endregion

    }
}
