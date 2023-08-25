using System;

namespace The_Most_Powerful_Word
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool end = false;

            string wordWinner = string.Empty;
            int scoreWinner = int.MinValue;

            while (!end)
            {
                string word = Console.ReadLine();

                if (word == "End of words")
                {
                    end = true;
                    break;
                }

                int wordScore = 0;

                for (int i = 0; i < word.Length; i++)
                {
                    int charNum = word[i];
                    wordScore += charNum;
                }

                if (word[0] == 'a' || word[0] == 'e' || word[0] == 'i' || word[0] == 'o' || word[0] == 'u' || word[0] == 'y' || word[0] == 'A' || word[0] == 'E' || word[0] == 'I' || word[0] == 'O' || word[0] == 'u' || word[0] == 'Y')
                {
                    wordScore = wordScore * word.Length;
                }
                else
                {
                    wordScore = wordScore / word.Length;
                }

                if (wordScore > scoreWinner)
                {
                    scoreWinner = wordScore;
                    wordWinner = word;
                }              
            }
            Console.WriteLine($"The most powerful word is {wordWinner} - {scoreWinner}");

        }
    }
}