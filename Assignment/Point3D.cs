using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Point3D : IComparable<Point3D>, ICloneable
    {

        #region Properties
        
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        #endregion

        #region Constructors
        
        public Point3D() : this(0, 0, 0) { }
        public Point3D(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        #endregion

        #region Methods
        
        public override string ToString() => $"Point Coordinates: ({X}, {Y}, {Z})";

        public int CompareTo(Point3D other)
        {
            int xComparison = X.CompareTo(other.X);
            if (xComparison != 0) return xComparison;
            return Y.CompareTo(other.Y);
        }

        public object Clone() => new Point3D(X, Y, Z); 

        #endregion

    }
}
