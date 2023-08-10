using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fødselsdagen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your birthday in the format ddMMyyyy.");
            DateTime birthday = DateTime.ParseExact(Console.ReadLine(), "ddMMyyyy", null);
            DateTime now = DateTime.Now;
            TimeSpan difference = now - birthday;
            int years = (int)Math.Floor(difference.TotalDays / 365.2425);
            birthday = birthday.AddYears(years);
            difference= now - birthday;
            int days = (int)Math.Floor(difference.TotalDays);
            Console.WriteLine("You are " + years + " years and " + days + " days old.");
            Console.ReadLine();
        }
    }
}
