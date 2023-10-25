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
                Console.WriteLine(dateObject.ToString());

                SalaryEmployee salaryEmployee = new SalaryEmployee()
                {
                    Id = 10291,
                    FirstName = Console.ReadLine(),
                    LastName = Console.ReadLine(),
                    BirthDate = dateObject,
                    HiringDate = dateObject,
                    IsActive = true,
                    Salary = Decimal.Parse(Console.ReadLine()),
                };

                Console.WriteLine(salaryEmployee);
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
