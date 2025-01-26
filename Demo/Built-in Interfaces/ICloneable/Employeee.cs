using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Built_in_Interfaces
{
    internal class Employeee : ICloneable
    {

        #region Properties
        
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Salary { get; set; }
        public Department? Department { get; set; }

        #endregion

        #region Constructors
        
        public Employeee()
        {

        }

        public Employeee(Employeee employeeCopy)
        {
            this.Id = employeeCopy.Id;
            this.Name = employeeCopy.Name;
            this.Salary = employeeCopy.Salary;
            if (employeeCopy.Department is not null)
                this.Department = new Department(employeeCopy.Department);
            this.Id = employeeCopy.Id;

        }

        #endregion

        #region Methods
        
        public object Clone()
        {

            //Merge Copy Constructor With Clone() Method - Return new object using copy constructor instead of empty parameterless constructor.

            #region Return new object using copy constructor

            return new Employeee(this);

            #endregion

            #region Return new object using empty parameterless constructor
            
            //return new Employeee()
            //{
            //    Id = this.Id,
            //    Name = this.Name,
            //    Salary = this.Salary,
            //    Department = (Department?)this.Department?.Clone()
            //}; 

            #endregion

        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Salary: {Salary}, Department => Code: {Department?.Code}, Title: {Department?.Title}";
        } 

        #endregion

    }
}
