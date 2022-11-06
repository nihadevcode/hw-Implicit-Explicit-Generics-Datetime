using Implicit_Explicit_Generics_Datetime.Homework1;
using Implicit_Explicit_Generics_Datetime.Homework2;
using System;

namespace Implicit_Explicit_Generics_Datetime
{
    class Program
    {
        public static void Main(string[] args)
        {

            Employee emp1 = new Employee();
            Employee emp2 = new Employee();

            object[] Employeee = { emp1, emp2 };
            Console.WriteLine(Employeee);

            #region Task2
            //Celcius cel1 = new Celcius();
            //Kelvin kel1 = new Kelvin();

            //double standart = 273.15;

            //cel1.Degree = double.Parse(Console.ReadLine());

            //kel1.Degree = cel1.Degree + standart;

            //Console.WriteLine(kel1.Degree);
            #endregion
        }
    }
}
