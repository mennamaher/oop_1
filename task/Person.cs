using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    internal struct Person
    {
        public string name;
        public int age;
        public object data;


        //public Person(object data)
        //{
        //    for (int i = 0; i < 3; i++) {
        //        name = "Ahmed";
        //        age = 24;
        //    }
        //}
        public Person(string _name, int _age)
        {
            name = "Ahmed";
            age = 24;
        }
        public override string ToString()
        {
            return $"name:{name}, Age:{age}";
        }
    } 
}
