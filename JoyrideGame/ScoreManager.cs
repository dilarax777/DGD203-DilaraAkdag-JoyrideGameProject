using System;
using System.Collections.Generic;
using System.IO;

namespace JoyrideGame
{
    class ScoreManager
    {
        private const string ScoresFile = "scores.txt";

        public void SaveScore(string name, int score)
        {
            using (StreamWriter writer = new StreamWriter(ScoresFile, true))
            {
                writer.WriteLine($"{name}:{score}");
            }
        }

        public Dictionary<string, int> LoadScores()
        {
            Dictionary<string, int> scores = new Dictionary<string, int>();
            if (File.Exists(ScoresFile))
            {
                string[] lines = File.ReadAllLines(ScoresFile);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(':');
                    if (parts.Length == 2)
                    {
                        scores[parts[0]] = int.Parse(parts[1]);
                    }
                }
            }
            return scores;
        }
    }
}