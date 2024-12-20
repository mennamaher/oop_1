using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    internal class Employee
    {
        //int id;
        //string name;
        //Gender sex;


        #region attributes
        public int Id;
        public string Name;
        private decimal salary;
        #endregion

        #region constructor
        public Employee(int _id, string _name, decimal _salary)
        {
            Id = _id; 
            Name= _name;
            salary = _salary;

        }
        #endregion

        public override string ToString() { 
        return $"Id:{Id} \n name:{Name} \n salary:{salary}";
                }

        #region Encapsulation
        // separate data definiton[attributes]
        //from it is ude [geetter- setter-indexer-property]

        //getter
        public string GetName()
        {
            return Name ;
        }

        //setter
        public void SetName(string value)
        {
              Name=value;
        }


        //property
        //.full property
        public decimal Salary
        {
            get
            {
                return salary;
            }
           private set { 
                salary = value;
            }
        }
        
        //automated prop
        public int age { get; set; }  //syntax sugar

        #endregion

    }
}
