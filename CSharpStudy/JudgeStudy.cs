using System;
namespace CSharpStudy
{
    public class JudgeStudy
    {
        public JudgeStudy()
        {
        }

        public static void SwitchExmaple()
        {
            int val = 1;
            switch(val)
            {
                case 0: Console.WriteLine("Hello World {0}", val); break;
                case 1: Console.WriteLine("Hello C# {0}", val); break;
            }

            char grade = 'B';

            switch (grade)
            {
                case 'A':
                    Console.WriteLine("很棒！");
                    break;
                case 'B':
                case 'C':
                    Console.WriteLine("做得好");
                    break;
                case 'D':
                    Console.WriteLine("您通过了");
                    break;
                case 'F':
                    Console.WriteLine("最好再试一下");
                    break;
                default:
                    Console.WriteLine("无效的成绩");
                    break;
            }
            Console.WriteLine("您的成绩是 {0}", grade);
        }
    }
}
