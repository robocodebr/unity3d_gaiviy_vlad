using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            String day = "k";
            switch (day)
            {
               case "s":Console.WriteLine("sunday"); break;
                case "m": Console.WriteLine("monday"); break;
                case "t": Console.WriteLine("tuesday"); break;
                case "w": Console.WriteLine("wensday"); break;
                case "th": Console.WriteLine("thursday"); break;
                case "f": Console.WriteLine("friday"); break;
                case "st": Console.WriteLine("sterday"); break;
                default: Console.WriteLine("not a day"); break;

            }
            float var1 = 10;
            double var2 = 11;
            short var3 = 12;
            if (var1 < var2 && var2 > var3) 
            {
                Console.WriteLine(var2);
            } else if(var1 < var3)
            {
                Console.WriteLine(var3);
            } else
            {

            }
          /*  long l = 12l;
            byte bt = 12;
            short sht = 13;
            if (bt > sht)
            {
                Console.WriteLine(bt);
                
            }
            else if (bt >= l)
            {
                Console.WriteLine(bt);
            }
            else { }
            {

            }
            Console.WriteLine("Hello World!");*/
        }
    }
}
