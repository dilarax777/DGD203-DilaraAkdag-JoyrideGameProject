using System;

namespace JoyrideGame
{
    class Forest : Location
    {
        public override void Visit(Player player)
        {
            Bella bella = new Bella();
            bella.Introduce();
            Console.Write("How do you feel? (1-10): ");
            int feeling = int.Parse(Console.ReadLine());
            player.Score += feeling;
            Console.WriteLine($"You gained {feeling} points. Total score: {player.Score}");
        }
    }
}