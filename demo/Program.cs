using common;
namespace demo
{
    enum Grades
    {
        A, B, C, D, F  //lables
    }

    enum Gender
    {
        Male = 1, M = 1, Female = 2, F = 2
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Definitions
            // what you can write inside namespace
            //1- class
            //2- struct
            //3- interface
            //4-Enum


            //allowed access modifiers inside namespace
            //1- internal >> default
            //2- public

            //what you can write insde struct or class
            //1- attribute (field-var)
            //2-property (full- automatic-indexer)
            //3-function (constructor- getter- settter-method)
            //4- event

            //allowed access modifiers inside struct
            //1- private
            //2-internal
            //3- public


            //allowed access modifiers inside class
            //1- private
            //2-private protected
            //3-protected
            //4-internal
            //5-internal protected
            //6-public

            // what you can write inside interface
            //1-signature for property
            //2- signature for method
            //3- default implemented method

            //default access modifiers inside interface is public


            #endregion

            #region class
            //typeA ob = new typeA();
            //ob.z = 1;
            //ob.x = 11; //invalide
            //ob.y = 11; //invalide
            #endregion

            #region Enum
            //Grades grade= Grades.A;
            //if (grade == Grades.A) {
            //    Console.WriteLine( "congrats A+ ");
            //}
            #endregion

            #region Struct
            //point p1=new point();
            ////new just for constructor selection
            ////declare  object from type point
            //Console.WriteLine( p1.x);
            #endregion

            #region Encapsulation
            Employee emp = new Employee(10, "menna",2000);
            //Console.WriteLine( emp);

            emp.SetName("ahmed");
            Console.WriteLine(emp.GetName());

           // emp.Salary = 1000;
            Console.WriteLine( emp.Salary);
            #endregion
        }
    }
}
