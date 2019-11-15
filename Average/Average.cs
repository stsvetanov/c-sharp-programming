using System;

namespace Average
{
    class Average
    {
        static void Main(string[] args)
        {
            double sum = 0;
            double counter = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if ("stop".Equals(input)) break;

                sum += double.Parse(input);
                Console.WriteLine("temporary sum: " + sum);
                counter++;
            }

            Console.WriteLine();
            Console.WriteLine("counter: " + counter);
            Console.WriteLine("sum: " + sum);
            Console.WriteLine("average: " + sum / counter);
        }
    }
}
