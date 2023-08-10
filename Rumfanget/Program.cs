using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rumfanget
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the height of the box in metres.");
            float height = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the width of the box in metres.");
            float width = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the length of the box in metres.");
            float length = float.Parse(Console.ReadLine());
            float volume = height * width * length;
            Console.WriteLine("The box has a volume of " + volume.ToString("0.00") + "m^3");
            Console.ReadLine();
        }
    }
}
