using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Built_in_Interfaces
{
    internal class Employeee0
    {

        #region Properties
        
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Salary { get; set; }
        public Department? Department { get; set; }

        #endregion

        #region Methods
        
        public object Clone()
        {
            return new Employeee0()
            {
                Id = this.Id,
                Name = this.Name,
                Salary = this.Salary,
                Department = (Department?)this.Department/*?.Clone()*/
            };
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Salary: {Salary}, Department => Code: {Department?.Code}, Title: {Department?.Title}";
        } 

        #endregion

    }
}
