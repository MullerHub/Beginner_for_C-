using System;
using System.IO;

namespace JogoDaForca
{

    class Words
    {
        private const string FileName = "words.txt";

        private Random random = new Random();

        private string[] words;

        public Words()
        {
            ReadWords();
        }

        private void ReadWords()
        {
            this.words = File.ReadAllLines(FileName);

            for (int i = 0; i < words.Length; i++)
            {

                words[i] = words[i].ToUpper();
            }
        }

        public string Pick()
        {
            int index = random.Next(words.Length);

            return words[index];
        }
    }
};
