using System;

namespace Algorithm_s_stek
{
    class Program
    {
        static void Main(string[] args)
        {
            Parser parser = new Parser();//"1,dec 1,4 1,5 3 4 5 2 2"
            parser.IsPrint = false;
            File_managment file = new File_managment("C:\\Users\\Admin\\source\\repos\\Algorithm's_stek\\input");

            MeasureTime timeMeasure = new MeasureTime(1000);
            Console.WriteLine();
            
            var result = timeMeasure.MethodTimeCounter(file.Commands, parser.Parse);
            foreach(var e in result)
            {
                Console.WriteLine("file name:"+ e.Key+" | Time:" + e.Value);

            }

        }
    }
}
