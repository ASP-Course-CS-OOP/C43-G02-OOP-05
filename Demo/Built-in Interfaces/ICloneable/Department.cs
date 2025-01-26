using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Built_in_Interfaces
{
    internal class Department : ICloneable
    {

        #region Properties
        
        public int Code { get; set; }
        public string Title { get; set; }

        #endregion

        #region Constructors
        
        public Department()
        {

        }

        public Department(Department departmentCopy)
        {
            this.Code = departmentCopy.Code;
            this.Title = departmentCopy.Title;
        }

        #endregion

        #region Methods
        
        public object Clone()
        {
            return new Department()
            {
                Code = this.Code,
                Title = this.Title
            };
        } 

        #endregion

    }
}
