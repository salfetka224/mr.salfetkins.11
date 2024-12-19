using System;
using System.IO;

public class Gamee
{
    public class Score
    {
        public int Points { get; set; }

        public void SaveScore(string filename)
        {
            File.AppendAllText(filename, $"Score: {Points}\n");
        }
    }
}