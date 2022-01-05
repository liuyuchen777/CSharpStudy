using System;
namespace CSharpStudy
{
    public class MethodStudy
    {
        public MethodStudy()
        {
        }

        private void Swap1(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        private void Swap2(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        private void ChangeVal(out int a)
        {
            a = 100;
        }

        public static void ValuePassExample()
        {
            int a = 100;
            int b = 200;
            MethodStudy ms = new MethodStudy();

            Console.WriteLine("Before Swap, a： {0}", a);
            Console.WriteLine("Before Swap, b： {0}", b);

            ms.Swap1(a, b);

            Console.WriteLine("Afetr Swap1, a： {0}", a);
            Console.WriteLine("After Swap1, b： {0}", b);

            ms.Swap2(ref a, ref b);

            Console.WriteLine("Afetr Swap2, a： {0}", a);
            Console.WriteLine("After Swap2, b： {0}", b);

            int c = 5;

            ms.ChangeVal(out c);

            Console.WriteLine("c = {0}", c);
        }
    }
}
