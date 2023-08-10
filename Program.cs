namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BlueAndRedLine();
            Blue6StarsAndRed();
            for(int i = 0; i < 2; i++)
            {
                Blue5StartsAndWhite();
                Blue6StarsAndWhite();
                Blue5StarsAndRed();
                Blue6StarsAndRed();
            }
            BlueAndWhiteLine();
            AllWhiteLine();
            for(int i = 0; i < 4; i++)
            {
                AllRedLine();
                AllRedLine();
                if(i < 3)
                {
                    AllWhiteLine();
                    AllWhiteLine();
                }
            }
        }
        static void Blue6StarsAndRed()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write(" ");
            for(int i = 0; i < 5; i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("*   ");
            }
            Console.Write("* ");
            for(int i = 0; i < 15; i++)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Write(" ");
            }
            Console.Write("\r\n");
        }
        static void Blue6StarsAndWhite()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write(" ");
            for (int i = 0; i < 5; i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("*   ");
            }
            Console.Write("* ");
            for (int i = 0; i < 15; i++)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.Write(" ");
            }
            Console.Write("\r\n");
        }
        static void Blue5StarsAndRed()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(" ");
                }
                if (i < 5)
                {
                    Console.Write("*");
                }
            }
            for(int i = 0; i < 15; i++)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Write(" ");
            }
            Console.Write("\r\n");
        }
        static void Blue5StartsAndWhite()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(" ");
                }
                if (i < 5)
                {
                    Console.Write("*");
                }
            }
            for (int i = 0; i < 15; i++)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.Write(" ");
            }
            Console.Write("\r\n");
        }
        static void BlueAndWhiteLine()
        {
            for (int i = 0; i < 23; i++)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.Write(" ");
            }
            for (int i = 0; i < 15; i++)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.Write(" ");
            }
            Console.Write("\r\n");
        }
        static void BlueAndRedLine()
        {
            for(int i = 0; i < 23; i++)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.Write(" ");
            }
            for(int i = 0; i < 15; i++)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Write(" ");
            }
            Console.Write("\r\n");
        }
        static void AllRedLine()
        {
            for (int i = 0; i < 38; i++)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Write(" ");
            }
            Console.Write("\r\n");
        }
        static void AllWhiteLine()
        {
            for (int i = 0; i < 38; i++)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.Write(" ");
            }
            Console.Write("\r\n");
        }
    }
}