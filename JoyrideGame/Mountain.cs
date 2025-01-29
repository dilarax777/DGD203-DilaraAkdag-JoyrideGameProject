using System;

namespace JoyrideGame
{
    class Mountain : Location
    {
        public override void Visit(Player player)
        {
            Eva eva = new Eva();
            eva.Introduce();
            Console.Write("Do you want to help Eva? (yes/no): ");
            string help = Console.ReadLine().ToLower();
            if (help == "yes")
            {
                player.Score += 10;
                Console.WriteLine("You gained 10 points. Total score: " + player.Score);
            }
            else
            {
                Console.WriteLine("You gained 0 points. Total score: " + player.Score);
            }
        }
    }
}