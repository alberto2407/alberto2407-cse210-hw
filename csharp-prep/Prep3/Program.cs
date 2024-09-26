using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magic_number = randomGenerator.Next(1, 101);
        int guess = -1;
        int count = 0;
        string answer = "";

        while (guess != magic_number)
        {
            Console.WriteLine("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            count++;

            if (guess > magic_number)
            {
                Console.WriteLine("Higher");
            }
            else if (guess < magic_number)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine($"You guessed it! The magic number is {magic_number}\nIt take you {count} times ");
            }

        }
    }
}
