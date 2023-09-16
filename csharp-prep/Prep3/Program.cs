using System;

class Program
{
    static void Main(string[] args)
    {
        // Part 1
        Console.Write("What is the magic number? ");
        string number1 = Console.ReadLine();
        int magicNumber = int.Parse(number1);

        Console.Write("What is your guess? ");
        string number2 = Console.ReadLine();
        int guessNumber = int.Parse(number2);

        if (guessNumber == magicNumber)
        {
            Console.WriteLine("You guessed it!");
        }
        else if (guessNumber < magicNumber)
        {
            Console.WriteLine("Higher");
        }
        else if (guessNumber > magicNumber)
        {
            Console.WriteLine("Lower");
        }

        //Part2
        Console.Write("What is the magic number? ");
        number1 = Console.ReadLine();
        magicNumber = int.Parse(number1);

        guessNumber = -1;

        while (guessNumber != magicNumber)
        {
            Console.Write("What is your guess? ");
            number2 = Console.ReadLine();
            guessNumber = int.Parse(number2);
            if (guessNumber < magicNumber)
            {
                Console.WriteLine("Higher");
                }
            else if (guessNumber > magicNumber)
            {
                Console.WriteLine("Lower");
                }
            else
            {
            Console.WriteLine("You guessed it!");
            }
        }
        

        // Part 3
        Random randomGenerator = new Random();
        magicNumber = randomGenerator.Next(1, 100);
        guessNumber = -1;

        while (guessNumber != magicNumber)
        {
            Console.Write("What is your guess? ");
            number2 = Console.ReadLine();
            guessNumber = int.Parse(number2);

            if (guessNumber < magicNumber)
            {
                Console.WriteLine("Higher");
                }
            else if (guessNumber > magicNumber)
            {
                Console.WriteLine("Lower");
                }
            else
            {
            Console.WriteLine("You guessed it!");
            }
        }
    }
}