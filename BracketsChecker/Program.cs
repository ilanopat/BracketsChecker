namespace BracketsChecker
{
    static class Program
    {
        public static void Main()
        {
            bool valid = false;
            while (!valid)
            {
                Console.Write("Please enter a text: ");
                string str = Console.ReadLine();
                if (!string.IsNullOrEmpty(str))
                {
                    bool check = Core.BracketsChecker.Check(str);
                    Console.WriteLine("Result: " + $"{check}");
                    break;
                }
            }
            Console.ReadKey();
        }        
    }
}