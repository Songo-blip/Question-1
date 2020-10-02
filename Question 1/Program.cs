using System;

namespace Numbers
{
    class Program
    {

        private static int BiggestNumber(int[] numbers)

        {
            int i;
            int Biggest = numbers[0];
            for (i = 1; i < numbers.Length; i++)
                if (numbers[i] > Biggest)
                    Biggest = numbers[i];

            return (Biggest);
        }

        static void Main(string[] args)
        {
            int[] mynumbers = { 2, 1, 7, 4, 9, 5 };

            int biggest = BiggestNumber(mynumbers);


            Console.WriteLine(biggest);
        }
    }

}
             