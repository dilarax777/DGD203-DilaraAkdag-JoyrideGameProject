using System;

namespace JoyrideGame
{
    class Game
    {
        private Player player;
        private ScoreManager scoreManager;

        public Game()
        {
            player = new Player();
            scoreManager = new ScoreManager();
        }

        public void Start()
        {
            Console.WriteLine("Welcome to Joyride!");
            MainMenu();
        }

        private void MainMenu()
        {
            while (true)
            {
                Console.WriteLine("1. New Game");
                Console.WriteLine("2. Credits");
                Console.WriteLine("3. All Scores");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        NewGame();
                        break;
                    case "2":
                        ShowCredits();
                        break;
                    case "3":
                        ShowAllScores();
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        private void NewGame()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            player.Name = name;
            player.Score = 0;

            Console.WriteLine($"Hello, {player.Name}! I'm Kate. Are you ready for an adventure?");
            LocationMenu();
        }

        private void LocationMenu()
        {
            while (true)
            {
                Console.WriteLine("Choose a location:");
                Console.WriteLine("1. Forest");
                Console.WriteLine("2. Mountain");
                Console.WriteLine("3. Lake");
                Console.WriteLine("4. Ready to end");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Forest forest = new Forest();
                        forest.Visit(player);
                        break;
                    case "2":
                        Mountain mountain = new Mountain();
                        mountain.Visit(player);
                        break;
                    case "3":
                        Lake lake = new Lake();
                        lake.Visit(player);
                        break;
                    case "4":
                        EndGame();
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        private void EndGame()
        {
            Console.WriteLine($"Game Over, {player.Name}! Your total score is {player.Score}.");
            scoreManager.SaveScore(player.Name, player.Score);
            Console.WriteLine("Type 'New' for a new game or any other key to exit.");
            string input = Console.ReadLine();
            if (input.ToLower() == "new")
            {
                MainMenu();
            }
            else
            {
                Environment.Exit(0);
            }
        }

        private void ShowCredits()
        {
            Console.WriteLine("Credits:");
            Console.WriteLine("Game developed by [Your Name].");
            Console.WriteLine("Sources: [List your sources here].");
            Console.WriteLine("Type 'return' to go back to the main menu.");
            if (Console.ReadLine().ToLower() == "return")
            {
                MainMenu();
            }
        }

        private void ShowAllScores()
        {
            Console.WriteLine("All Scores:");
            var scores = scoreManager.LoadScores();
            foreach (var score in scores)
            {
                Console.WriteLine($"{score.Key}: {score.Value}");
            }
            Console.WriteLine("Type 'return' to go back to the main menu.");
            if (Console.ReadLine().ToLower() == "return")
            {
                MainMenu();
            }
        }
    }
}