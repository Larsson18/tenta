using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Nobel
{
    public class Person
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public bool IsWinner { get; set; }
        public int Year { get; set; }


        // skapar en tostring metod för att få in namnen i listboxen
        public override string ToString()
        {
            // https://stackoverflow.com/questions/3890956/how-to-get-current-month-and-year för DateTime.Now.Year
            if (Year == DateTime.Now.Year)
            {
                return Firstname + " " + Lastname + "-" + "Nybliven vinnare";
            }
            else if (IsWinner==true)
            {
                return Firstname + " " + Lastname + (Year - Convert.ToInt16(DateTime.Now.Year));
            }
            else
            {
            return Firstname + " " + Lastname;

            }
        }
    }
}
