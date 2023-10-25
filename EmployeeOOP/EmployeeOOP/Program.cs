using EmployeeOOP.Classes;
using System;

namespace EmployeeOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int day, month, year;
                Console.WriteLine("OOP APLICATION");
                Console.WriteLine("==============");

                Console.Write("Ingresar el día: ");
                day = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ingresar el Mes: ");
                month = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ingresar el año: ");
                year = Convert.ToInt32(Console.ReadLine());


                //Inicialización de la clase Date
                Date dateObject = new Date(day, month, year);
                Console.ReadKey();
                Console.WriteLine(dateObject.ToString());
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
