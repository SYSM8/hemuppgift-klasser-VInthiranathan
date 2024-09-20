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

        public string Fname { get; set; }
        public string Lname { get; set; }
        public double Sal { get; set; }

        //konstruktor
        public Employee(string Fname, string Lname)
        {
            // Ger värde till fields i klassen
            this.Fname = Fname;
            this.Lname = Lname;
        }
        //metoder
        public int GiveRaise(double per)
        {
            per = per / 100; //gör om till procent
            Sal = Sal * (1 + per); //ge det nya värdet till gamla lönen
            return Convert.ToInt32(Sal); // returnera nya månadslönen
        }

        public int GetAnnualSalary()
        {
            //returnerar årliga lönen
            return Convert.ToInt32(Sal * 12);
        }

    }
}
