namespace CSharpStudy
{
    public class LoopStudy
    {
        public LoopStudy()
        {
            
        }

        public static void ForEachExample()
        {
            int[] fibarray = new int[] { 0, 1, 2, 3, 4, 5 };
            foreach (int element in fibarray)
            {
                System.Console.WriteLine(element);
            }
            System.Console.WriteLine();

            int count = 0;
            foreach (int element in fibarray)
            {
                count += 1;
                System.Console.WriteLine("Element #{0}: {1}", count, element);
            }
            System.Console.WriteLine("Number of elements in the array: {0}", count);
        }
    }
}
