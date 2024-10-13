using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;
{
    Console.WriteLine("Hello there, and welcome to the Coin Flip Challenge. Please enter your name:");
    string name = Console.ReadLine();
    {
        Console.WriteLine("Thank you " + name + ", do you agree to participate in this game of chance? (yes/no)");
        string? proceed = "yes";
        if (!(proceed == Console.ReadLine()))
        {
            Console.WriteLine("You are a coward, " + name);
        }

        Console.WriteLine("Wonderful! Then let us begin, " + name);
        int score = 0;
        for (int round = 0; round <= 5; round++)
        {
            round = round++;
            Random coin = new Random();
            int flip = coin.Next(0, 2);
            string? heads = "heads";
            string? tails = "tails";
            Console.WriteLine("heads or tails?");
            if (heads == Console.ReadLine())
            {
                int choiceh = 0;
                if (flip == choiceh)
                {
                    Console.WriteLine("Correct!");
                    score = score++;
                }
                else if (flip != choiceh)
                {
                    Console.WriteLine("Wrong!");
                }
            }
            else if (tails == Console.ReadLine())
            {
                int choicet = 1;
                if (flip == choicet)
                {
                    Console.WriteLine("Correct!");
                    score = score++;
                }
                else if (flip != choicet)
                {
                    Console.WriteLine("Wrong!");
                }
            }

            if (round == 5)
            {
                Console.WriteLine("Congratulations, " + name + ", you had a score of: " + score);
                break;
            }
        }
    }
}
