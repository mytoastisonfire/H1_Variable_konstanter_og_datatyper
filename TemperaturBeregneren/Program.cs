using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperaturBeregneren
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the temperature in Celcius.");
            sbyte celcius = sbyte.Parse(Console.ReadLine());
            float fahrenheit = (Convert.ToSingle(celcius) * 1.8f) + 32;
            float reamur = (Convert.ToSingle(celcius) * 0.8f);
            Console.WriteLine("It is " + fahrenheit.ToString("0.0") + "°F or " + reamur.ToString("0.0") + "°R");
            Console.ReadLine();
        }
    }
}
