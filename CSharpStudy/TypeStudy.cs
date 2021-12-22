using System;
namespace CSharpStudy
{
    public class TypeStudy
    {
        public const int constVal1 = 1; // const defintion
        public const int constVal2 = constVal1 + 5;

        public TypeStudy()
        {
        }

        public static void StringConversionExample()
        {
            Console.WriteLine("------------------------");

            int i = 75;
            float f = 53.005f;
            double d = 2345.7652;
            bool b = true;

            Console.WriteLine(i.ToString());
            Console.WriteLine(f.ToString());
            Console.WriteLine(d.ToString());
            Console.WriteLine(b.ToString());
        }
    }
}
