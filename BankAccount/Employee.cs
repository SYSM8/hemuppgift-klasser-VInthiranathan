using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Vithunan Inthiranathan
namespace BankAccount
{
    public class Employee
    {
        //Lägg till Egenskaper (fields)
        //Lägg till Konstruktor
        //Lägg till Metoder
        //Lycka till! :)

        //fields
        private string firstName;
        private int age;
        private double sal;


        //properties
        public string FName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value > 0)
                {
                    age = value;
                }
                else
                {
                    age = 0;
                }
            }
        }
        public double Sal
        {
            get
            {
                return sal;
            }
            set
            {
                if (value >= 0)
                {
                    sal = value;
                }
            }
        }

        //konstruktor
        public Employee(string Fname, int age)
        {
            // Ger värde till fields i klassen
            this.FName = Fname;
            this.Age = age;
        }
        //metoder
        public int GiveRaise(double per)
        {
            per = per / 100; //gör om till procent
            Sal += Sal * per; //ge det nya värdet till gamla lönen
            return Convert.ToInt32(Sal); // returnera nya månadslönen
        }

        public int GetAnnualSalary()
        {
            //returnerar årliga lönen
            return Convert.ToInt32(Sal * 12);
        }
        public void DisplayEmployeeInfo()
        {
            Console.WriteLine($"Name: {FName} \nAge: {Age} \nSalary: {Sal}");
        }

    }
}
