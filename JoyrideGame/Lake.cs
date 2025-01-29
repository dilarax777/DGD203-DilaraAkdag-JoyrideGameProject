using System;

namespace JoyrideGame
{
    class Lake : Location
    {
        public override void Visit(Player player)
        {
            Jade jade = new Jade();
            jade.Introduce();
            Console.Write("How brave are you? (1-10): ");
            int bravery = int.Parse(Console.ReadLine());
            player.Score += bravery;
            Console.WriteLine($"You gained {bravery} points. Total score: {player.Score}");
        }
    }
}