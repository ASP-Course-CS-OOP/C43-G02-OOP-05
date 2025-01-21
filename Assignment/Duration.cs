using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Duration
    {

        #region Properties
        
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        #endregion

        #region Constructors
        
        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours + minutes / 60 + seconds / 3600;
            Minutes = (minutes + seconds / 60) % 60;
            Seconds = seconds % 60;
        }

        public Duration(int totalSeconds)
        {
            Hours = totalSeconds / 3600;
            Minutes = (totalSeconds % 3600) / 60;
            Seconds = totalSeconds % 60;
        }

        #endregion

        #region Methods
        
        public override string ToString()
        {
            return $"Hours: {Hours}, Minutes: {Minutes}, Seconds: {Seconds}".TrimEnd(',');
        }


        #endregion

    }

}
