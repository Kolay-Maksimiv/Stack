namespace Stack
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();

            int ini = 0;
            int max = 5;

            for (int i = ini; i <= max; i++)
                stack.Push(i);

            for (int i = ini; i <= max ; i++)
                Console.WriteLine(stack.Pop());

        }
    }
}
