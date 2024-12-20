namespace task
{
    //1-
    enum WeekDays
    {
        Monday,Tuesday, Wednesday,Thursday,Friday,Saturday,Sunday
    }

    //3-
    enum Seasons
    {
        Spring, Summer, Autumn, Winter
    }

    //5-
    enum Colors
    {
        red,green, blue
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1)
            //for (int i = 0; i < 7; i++)
            //{
            //    WeekDays days = (WeekDays)i;
            //    Console.WriteLine(days);
            //}
            #endregion

            #region 2)
            //Person p1 = new Person("Ahmed", 27);
            //Person p2 = new Person("Menna", 25);
            //Person p3 = new Person("Mai", 20);

            // Console.WriteLine( p1);


            ////Person[] arr = [
            ////  new Person("Ahmed", 27),
            ////  new Person("Menna", 25)
            ////    ];
            ////foreach (Person p in arr) {
            ////    Console.WriteLine( arr);
            ////}


            #endregion

            #region 3)
            //Seasons season = new Seasons();
            //Console.WriteLine("enter season");
            //Console.ReadLine();

            //switch (season)
            //{
            //    case Seasons.Spring:
            //        Console.WriteLine("march to may ");
            //        break;
            //    case Seasons.Summer:
            //        Console.WriteLine("june to august  ");
            //        break;
            //    case Seasons.Winter:
            //        Console.WriteLine("December to February ");
            //        break;
            //    case Seasons.Autumn:
            //        Console.WriteLine("September to November ");
            //        break;
            //}
            #endregion

            #region 5)
            // Colors color=new Colors();
            //Console.WriteLine("enter color");
            //Console.ReadLine();
            ////if (color==Colors.red || color == Colors.blue || color == Colors.green)
            ////{
            ////    Console.WriteLine("Primary ");
            ////}
            ////else
            ////{
            ////    Console.WriteLine("Secondary");
            ////}

            //switch (color)
            //{
            //    case Colors.red:
            //    case Colors.blue:
            //    case Colors.green:

            //        Console.WriteLine("Primary ");
            //        break;

            //    default:
            //        Console.WriteLine("Secondary");
            //        break;
            //}

            #endregion

            #region 6)
            //Point p = new Point(3,4,4,3);

            ////Console.WriteLine("Enter  point 1");
            ////Console.ReadLine();
            ////Console.WriteLine("Enter  point 2");
            ////Console.ReadLine();

            ////Console.WriteLine(p.res);


            //Console.WriteLine(p);

            #endregion
        }
    }
}
