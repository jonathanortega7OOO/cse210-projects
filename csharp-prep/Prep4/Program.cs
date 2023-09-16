using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int number=-1;
        
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (number !=0)
        {
            Console.Write("Enter number: ");

            string answer = Console.ReadLine();
            number= int.Parse(answer);

            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        //part 1
        int sum=0;
        for (int i = 0; i < numbers.Count; i++)
        {
            sum = sum + numbers[i];
            }
        
        Console.WriteLine($"The sum is: {sum}");
        
        //part2
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        //part3
        int largestNumber= numbers[0];
        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] > largestNumber)
            {
                largestNumber = numbers[i];
            }
        }
        
        Console.WriteLine($"The largest number is: {largestNumber}");
    }
}