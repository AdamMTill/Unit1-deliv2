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
            return;
        }

        Console.WriteLine("Wonderful! Then let us begin, " + name);
        int score = 0;
        for (int round = 1; round <= 5; round++)
        {
            Console.WriteLine("heads or tails?");
            string guess = Console.ReadLine();
            round = round++;
            Random coin = new Random();
            int flip = coin.Next(0, 2);
            string flip_face = "";
            if (flip == 0)
            {
                flip_face = "tails";
            }
            else
            {
                flip_face = "heads";
            }

            if (guess == flip_face)
            {
                Console.WriteLine("Correct!");
                score = score++;
            }
            else
            {
                Console.WriteLine("Wrong!");
            }

            if (round == 5)
            {
                Console.WriteLine("Congratulations, " + name +  ", you had a score of: " + score);
                break;
            }
        }
    }
}
