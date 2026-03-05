namespace Topic_6__Random_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Naika

            // 4. Creating a random number generator
            //    You can optionally add a seed to get reproducible random numbers:
            //    Random generator = new Random(12353); // Using a seed
            //    If you remove the seed, numbers will be different each run
            Random generator = new Random();

            int randNum; // We will store our random number in this variable

            // 1. Random number from 0-9 (Next(10) generates 0 to 9)
            randNum = generator.Next(10);
            //    To get numbers from 0-5, use generator.Next(6)
            //    To get numbers from 0-100, use generator.Next(101)

            Console.WriteLine("My random number is " + randNum);

            Console.WriteLine("Here are some numbers from 0 to 4!");
            // 2. Change the Next() calls from 0-4
            //    Original: generator.Next(5) -> produces 0,1,2,3,4
            //    Example change: generator.Next(1, 6) -> produces 1,2,3,4,5
            //    For 3 to 5: generator.Next(3, 6) -> produces 3,4,5
            Console.Write(generator.Next(1, 6) + " ");
            Console.Write(generator.Next(1, 6) + " ");
            Console.Write(generator.Next(1, 6) + " ");
            Console.Write(generator.Next(1, 6) + " ");
            Console.Write(generator.Next(1, 6) + " ");
            Console.WriteLine(generator.Next(1, 6) + " ");

            Console.WriteLine();
            Console.WriteLine("Here are some numbers from 0 to 99!");
            // Random numbers from 0-99
            Console.Write(generator.Next(100) + " ");
            Console.Write(generator.Next(100) + " ");
            Console.Write(generator.Next(100) + " ");
            Console.Write(generator.Next(100) + " ");
            Console.Write(generator.Next(100) + " ");
            Console.WriteLine(generator.Next(100) + " ");

            Console.WriteLine();

            int num1 = generator.Next(10);
            int num2 = generator.Next(10);

            if (num1 == num2)
            {
                Console.WriteLine("The random numbers were the same! Weird.");
            }
            if (num1 != num2)
            {
                Console.WriteLine("The random numbers were different! Not weird. ");
            }

            Console.ReadLine(); // Keeps the program from quitting

            // 3. Using a fixed seed like Random generator = new Random(12353);
            //    If you run with a fixed seed, the sequence of "random" numbers
            //    will be exactly the same each time you run the program.
            //    Changing the seed changes the sequence.
            //    Removing the seed returns true randomness (as random as software allows).




        }

    }
}