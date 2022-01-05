using System;

namespace CSharpStudy
{
    class Program
    {
        private void HelloWorld()
        {
            Console.WriteLine("Hello World!");
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            int val1 = 10;
            var val2 = 10;

            program.HelloWorld();

            TypeStudy.StringConversionExample();
            JudgeStudy.SwitchExmaple();
            LoopStudy.ForEachExample();
            MethodStudy.ValuePassExample();
            ClassStudy.OverrideExample();

            Console.WriteLine(val1.GetType());
            Console.WriteLine(val2.GetType());

            // The Length property provides the number of array elements.
            Console.WriteLine($"parameter count = {args.Length}");

            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine($"Arg[{i}] = [{args[i]}]");
            }
        }
    }
}
