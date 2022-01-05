using System;
namespace CSharpStudy
{
    interface IMyInterface
    {
        // 接口成员
        void MethodToImplement();
    }

    class InterfaceImplementer : IMyInterface
    {
        public void MethodToImplement()
        {
            Console.WriteLine("MethodToImplement() called.");
        }
    }

    public class InterfaceExample
    {
        public InterfaceExample()
        {
        }

        public static void ImplementExample()
        {
            InterfaceImplementer iImp = new();
            iImp.MethodToImplement();
        }
    }
}
