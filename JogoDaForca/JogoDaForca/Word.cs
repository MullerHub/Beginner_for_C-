using System;

namespace JogoDaForca
{
    internal class Word
    {
        private const char WildCard = '*';

        private Words words = new Words();

        private char[] completeWordChars;

        private char[] partialWordChars;

        public string CompleteWord { get; private set; }

        public string PartialWord
        {
            get
            {
                return new string(partialWordChars);
            }
        }

        public bool Finished
        {
            get
            {
                return PartialWord == CompleteWord;
            }
        }

        public Word()
        {
            Next();
        }

        public void Next()
        {
            this.CompleteWord = words.Pick();

            this.completeWordChars = this.CompleteWord.ToCharArray();

            this.partialWordChars = new char[completeWordChars.Length];
            for (int i = 0; i < partialWordChars.Length; i++)
            {
                if (completeWordChars[i] != ' ')
                {
                    partialWordChars[i] = WildCard;
                }
                else
                {
                    partialWordChars[i] = ' ';
                }
            }
        }

        public bool Guess(char letter)
        {
            bool found = false;

            letter = Char.ToUpper(letter);

            for(int i = 0; i < completeWordChars.Length; i++)
            {
                if (completeWordChars[i] == letter)
                {
                    partialWordChars[i] = letter;
                    found = true;
                }
            }

            return found;
        }
    }
}
