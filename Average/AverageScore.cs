namespace Average;

class Program
{
    static void Main(string[] args)
    {
        double score1;
        double score2;
        double score3;
        double average;



        Console.WriteLine("Enter score 1: ");
        score1 = Convert.ToDouble(Console.ReadLine());


        Console.WriteLine("Enter score 2: ");
        score2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter score 3: ");
        score3 = Convert.ToDouble(Console.ReadLine());

        average = (score1 + score2 + score3) / 3;




        Console.WriteLine($"Your average score is {Math.Round(average, 2)}. ");


        if (average > 95)
        {
            Console.WriteLine("That's a great score! ");

        }

    }
}

