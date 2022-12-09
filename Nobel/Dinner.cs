using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Nobel
{
    internal class Dinner
    {
        Person person = new Person();
       public List<Person> Guests { get; set; } = new List<Person>()
         { new Person(){Id=1, Firstname="Laurel", Lastname="Pittham", IsWinner=false, Title="Ms", Year=0},
    new Person(){Id=2, Firstname="Lindy", Lastname="Knowller", IsWinner=false, Title="Dr", Year=0},
    new Person(){Id=3, Firstname="Jasun", Lastname="Steinson", IsWinner=false, Title="Rev", Year=0},
    new Person(){Id=4, Firstname="Clarinda", Lastname="Paulton", IsWinner=true, Title="Honorable", Year=1985},
    new Person(){Id=5, Firstname="Quint", Lastname="Pratton", IsWinner=true, Title="Rev", Year=1996},
    new Person(){Id=6, Firstname="Estell", Lastname="Instrell", IsWinner=false, Title="Honorable", Year=0},
    new Person(){Id=7, Firstname="Kora", Lastname="Kovnot", IsWinner=false, Title="Honorable", Year=0},
    new Person(){Id=8, Firstname="Henryetta", Lastname="Jekel", IsWinner=false, Title="Rev", Year=0},
    new Person(){Id=9, Firstname="Anderea", Lastname="Frankland", IsWinner=false, Title="Mrs", Year=0},
    new Person(){Id=10, Firstname="Rutherford", Lastname="Trenbey", IsWinner=true, Title="Mr", Year=2000},
    new Person(){Id=11, Firstname="Sherilyn", Lastname="Dwyer", IsWinner=true, Title="Honorable", Year=2007},
    new Person(){Id=12, Firstname="Flo", Lastname="Papierz", IsWinner=false, Title="Mr", Year=0},
    new Person(){Id=13, Firstname="Elmo", Lastname="Trathen", IsWinner=true, Title="Mrs", Year=2010},
    new Person(){Id=14, Firstname="Dalt", Lastname="Hoyle", IsWinner=false, Title="Dr", Year=0},
    new Person(){Id=15, Firstname="Con", Lastname="Danbi", IsWinner=false, Title="Ms", Year=0},
    new Person(){Id=16, Firstname="Alick", Lastname="Greenrod", IsWinner=false, Title="Ms", Year=0},
    new Person(){Id=17, Firstname="Pavia", Lastname="Brantl", IsWinner=true, Title="Mrs", Year=1996},
    new Person(){Id=18, Firstname="Kaiser", Lastname="Skeates", IsWinner=true, Title="Dr", Year=2008},
    new Person(){Id=19, Firstname="Athene", Lastname="Yellowlee", IsWinner=false, Title="Mrs", Year=0},
    new Person(){Id=20, Firstname="Harmonia", Lastname="Springham", IsWinner=false, Title="Mr", Year=0},
    new Person(){Id=21, Firstname="Reuven", Lastname="Jasik", IsWinner=true, Title="Mr", Year=2008},
    new Person(){Id=22, Firstname="Brandyn", Lastname="Seagar", IsWinner=true, Title="Mrs", Year=1997},
    new Person(){Id=23, Firstname="Owen", Lastname="Sherington", IsWinner=false, Title="Mrs", Year=0},
    new Person(){Id=24, Firstname="Harmonia", Lastname="Kenrack", IsWinner=true, Title="Rev", Year=1984},
    new Person(){Id=25, Firstname="Vere", Lastname="Traice", IsWinner=false, Title="Rev", Year=0},
    new Person(){Id=26, Firstname="Niel", Lastname="Aughtie", IsWinner=false, Title="Ms", Year=0},
    new Person(){Id=27, Firstname="Lay", Lastname="Keiley", IsWinner=false, Title="Honorable", Year=0},
    new Person(){Id=28, Firstname="Ava", Lastname="Veillard", IsWinner=false, Title="Dr", Year=0},
    new Person(){Id=29, Firstname="Karissa", Lastname="Radenhurst", IsWinner=false, Title="Dr", Year=0},
    new Person(){Id=30, Firstname="Damon", Lastname="Shorten", IsWinner=false, Title="Dr", Year=0},
    new Person(){Id=31, Firstname="Vittorio", Lastname="Karslake", IsWinner=true, Title="Ms", Year=2006},
    new Person(){Id=32, Firstname="Rowen", Lastname="Simakov", IsWinner=true, Title="Ms", Year=1993},
    new Person(){Id=33, Firstname="Alden", Lastname="Leonardi", IsWinner=true, Title="Mrs", Year=2003},
    new Person(){Id=34, Firstname="Georgy", Lastname="Sleeny", IsWinner=false, Title="Dr", Year=0},
    new Person(){Id=35, Firstname="Robinet", Lastname="Agneau", IsWinner=false, Title="Mr", Year=0},
    new Person(){Id=36, Firstname="Renault", Lastname="Morshead", IsWinner=true, Title="Mrs", Year=2007},
    new Person(){Id=37, Firstname="Nadiya", Lastname="Slay", IsWinner=true, Title="Dr", Year=1996},
    new Person(){Id=38, Firstname="Maren", Lastname="Barnaby", IsWinner=true, Title="Honorable", Year=2009},
    new Person(){Id=39, Firstname="Ronna", Lastname="Moogan", IsWinner=true, Title="Mr", Year=1997},
    new Person(){Id=40, Firstname="Sheilakathryn", Lastname="Lattka", IsWinner=true, Title="Ms", Year=2009},
    new Person(){Id=41, Firstname="Dita", Lastname="Yateman", IsWinner=true, Title="Dr", Year=1997},
    new Person(){Id=42, Firstname="Ricky", Lastname="Oleksinski", IsWinner=false, Title="Mrs", Year=0},
    new Person(){Id=43, Firstname="Lydie", Lastname="Scholfield", IsWinner=true, Title="Dr", Year=1988},
    new Person(){Id=44, Firstname="Mildred", Lastname="Land", IsWinner=false, Title="Honorable", Year=0},
    new Person(){Id=45, Firstname="Benson", Lastname="Braam", IsWinner=true, Title="Honorable", Year=1999},
    new Person(){Id=46, Firstname="Rancell", Lastname="Tritton", IsWinner=true, Title="Dr", Year=2006},
    new Person(){Id=47, Firstname="Deanna", Lastname="Martijn", IsWinner=false, Title="Rev", Year=0},
    new Person(){Id=48, Firstname="Milty", Lastname="Du Pre", IsWinner=true, Title="Mr", Year=2000},
    new Person(){Id=49, Firstname="Roda", Lastname="Ledrun", IsWinner=false, Title="Dr", Year=0},
    new Person(){Id=50, Firstname="Alfonse", Lastname="O'Kinedy", IsWinner=false, Title="Mrs", Year=0},
    new Person(){Id=51, Firstname="Timothee", Lastname="Jirka", IsWinner=true, Title="Mrs", Year=1992},
    new Person(){Id=52, Firstname="Taylor", Lastname="Simakov", IsWinner=true, Title="Honorable", Year=2022},
    new Person(){Id=53, Firstname="Raquela", Lastname="Gounin", IsWinner=false, Title="Rev", Year=0},
    new Person(){Id=54, Firstname="Carmella", Lastname="Dailey", IsWinner=false, Title="Honorable", Year=0},
    new Person(){Id=55, Firstname="Sigvard", Lastname="Racine", IsWinner=true, Title="Mr", Year=1995},
    new Person(){Id=56, Firstname="Lazare", Lastname="Costain", IsWinner=true, Title="Honorable", Year=2000},
    new Person(){Id=57, Firstname="Waylin", Lastname="Bennison", IsWinner=false, Title="Mr", Year=0},
    new Person(){Id=58, Firstname="Murvyn", Lastname="Kordas", IsWinner=false, Title="Dr", Year=0},
    new Person(){Id=59, Firstname="Goldina", Lastname="Martinyuk", IsWinner=false, Title="Mr", Year=0},
    new Person(){Id=60, Firstname="Alain", Lastname="Hanselman", IsWinner=true, Title="Ms", Year=2012},
    new Person(){Id=61, Firstname="Kris", Lastname="Bilton", IsWinner=true, Title="Rev", Year=1992},
    new Person(){Id=62, Firstname="Dwain", Lastname="Braams", IsWinner=false, Title="Ms", Year=0},
    new Person(){Id=63, Firstname="Milissent", Lastname="Yakuntzov", IsWinner=true, Title="Dr", Year=1992},
    new Person(){Id=64, Firstname="Dominick", Lastname="Lytlle", IsWinner=true, Title="Honorable", Year=1994},
    new Person(){Id=65, Firstname="Isadore", Lastname="Bryant", IsWinner=false, Title="Mrs", Year=0},
    new Person(){Id=66, Firstname="Kristin", Lastname="Andreix", IsWinner=false, Title="Mrs", Year=0},
    new Person(){Id=67, Firstname="Denice", Lastname="Bottomley", IsWinner=true, Title="Honorable", Year=2010},
    new Person(){Id=68, Firstname="Jefferey", Lastname="Rudgley", IsWinner=false, Title="Dr", Year=0},
    new Person(){Id=69, Firstname="Hinda", Lastname="Letchmore", IsWinner=false, Title="Dr", Year=0},
    new Person(){Id=70, Firstname="Salomon", Lastname="Haresnape", IsWinner=false, Title="Mr", Year=0},
    new Person(){Id=71, Firstname="Annie", Lastname="Tonkinson", IsWinner=true, Title="Ms", Year=2006},
    new Person(){Id=72, Firstname="Jamie", Lastname="Shotton", IsWinner=false, Title="Dr", Year=0},
    new Person(){Id=73, Firstname="Grady", Lastname="Dodell", IsWinner=false, Title="Dr", Year=0},
    new Person(){Id=74, Firstname="Misha", Lastname="Matchitt", IsWinner=true, Title="Ms", Year=2011},
    new Person(){Id=75, Firstname="Diann", Lastname="Wasielewski", IsWinner=true, Title="Honorable", Year=2022},
    new Person(){Id=76, Firstname="Rowland", Lastname="Izakoff", IsWinner=false, Title="Dr", Year=0},
    new Person(){Id=77, Firstname="Humbert", Lastname="Eliet", IsWinner=false, Title="Mr", Year=0},
    new Person(){Id=78, Firstname="Cher", Lastname="Storr", IsWinner=true, Title="Dr", Year=1986},
    new Person(){Id=79, Firstname="Tamara", Lastname="Winders", IsWinner=false, Title="Dr", Year=0},
     new Person(){Id=80, Firstname="Terrye", Lastname="Earp", IsWinner=true, Title="Dr", Year=2010},

    };
        int winnersValue = 0;
        int nonWinnersValue = 0;
        int secretGuest = 0;
        public string GetWinners(int winningYear) 
        {
            string winners;
            foreach (Person person in Guests)
            {

                if (winningYear == person.Year && person.IsWinner==true)
                {
                    
                    winners = person.Firstname;
                    return winners;
                }

            }
            return null;
            //return winners;
        
        }

    public void GetSeatNumber(string seat) 
        {

            string [] correctSeat = new string[seat.Length];
            // en for loop som går igenom länged av strängen
            for (int i = 0; i < seat.Length; i++)
            {
                // if-värdet den går igenom är över 0 läggs den till
                if (i>0)
                {
                    correctSeat[i] = i.ToString();
                } 
            }
        }

        // i denna lösning använder jag ej några in/utdata parametrar, jag kallar på de vanliga metoderna vilket returnar det jag vill arbeta med
        // för att denna lösning ska fungera krävs det inte några in/ut data förutom returns.
        public void FindSecretGuest() 
        {

            FindNobelWinners();
            FindNonWinners();
            secretGuest = winnersValue + nonWinnersValue;
            foreach (Person person in Guests)
            {

                if (person.Id == secretGuest)
                {
                    MessageBox.Show($"Den hemliga gästen är {secretGuest.ToString(person.Firstname)} {secretGuest.ToString(person.Lastname)}");
                    
                }
            }
            

        }
        public int FindNobelWinners() 
        {
            //int[] nobelWinners = new int[Guests.Count];
            foreach (Person person in Guests)
            {

                if (person.IsWinner == true)
                {
                    if (person.Title == "Honorable")
                    {
                        winnersValue += 9;
                    }
                    else if (person.Title == "Ms")
                    {
                        winnersValue += 2;
                    }
                    else if (person.Title == "Dr")
                    {
                        winnersValue += 2;
                    }
                    else if (person.Title == "Rev")
                    {
                        winnersValue += 3;
                    }
                    else if (person.Title == "Mrs")
                    {
                        winnersValue += 3;
                    }
                    else if (person.Title == "Mr")
                    {
                        winnersValue += 2;
                    }

                }

            }
            // jag returnar en int för att den ska vara möjlig att adderas ihopp med den negativa intergern i andra metoden

            return winnersValue;


            // provade först med en for loop men funkade inte då

            //for (int i = 0; i < Guests.Count; i++)
            //{
            //    if (person.IsWinner==true)
            //    {
            //        if (person.Title == "Honorable")
            //        {
            //            winnersValue += 9;
            //        }
            //        else if (person.Title == "Ms")
            //        {
            //            winnersValue += 2;
            //        }
            //        else if (person.Title == "Dr")
            //        {
            //            winnersValue += 2;
            //        }
            //        else if (person.Title == "Rev")
            //        {
            //            winnersValue += 3;
            //        }
            //        else if (person.Title == "Mrs")
            //        {
            //            winnersValue += 3;
            //        }
            //        else if (person.Title == "Mr")
            //        {
            //            winnersValue += 2;
            //        }
            //    }

            //}

        }

        public int FindNonWinners() 
        {

            // återanvänder samma kod då jag vill få fram två int värden, en med alla negativa och en med alla positiva
            foreach (Person person in Guests)
            {

                if (person.IsWinner == false)
                {
                    if (person.Title == "Honorable")
                    {
                        nonWinnersValue -= 9;
                    }
                    else if (person.Title == "Ms")
                    {
                        nonWinnersValue -= 2;
                    }
                    else if (person.Title == "Dr")
                    {
                        nonWinnersValue -= 2;
                    }
                    else if (person.Title == "Rev")
                    {
                        nonWinnersValue -= 3;
                    }
                    else if (person.Title == "Mrs")
                    {
                        nonWinnersValue -= 3;
                    }
                    else if (person.Title == "Mr")
                    {
                        nonWinnersValue -= 2;
                    }

                }

            
            }
            // jag returnar en int för att den ska vara möjlig att adderas ihopp med den positiva intergern i andra metoden

            return nonWinnersValue;

        }
    }
}
