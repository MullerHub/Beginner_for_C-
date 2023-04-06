using JogoDaForca;
using System;
using System.Collections.Generic;

namespace jogoDaForca
{
    class Game
    {
        private int maxErrors;

        public Game(int maxErrors)
        {
            this.maxErrors = maxErrors;
        }

        public void Play()
        {
            Word w = new Word();

            while (true)
            {
                Console.WriteLine("--- JOGO DA FORCA --- /n");
                Console.WriteLine("Você pode errar no maximo {0} vezes /n", maxErrors);

                int errors = 0;

                ISet<char> triedLetters = new HashSet<char>();

                while (!w.Finished && errors < maxErrors)
                {
                    Console.WriteLine(w.PartialWord);

                    Console.Write("/nDigite uma letra: ");
                    string letter = Console.ReadLine();

                    if (String.IsNullOrWhiteSpace(letter))
                    {

                        continue;
                    }

                    if (triedLetters.Contains(letter[0]))
                    {
                        Console.WriteLine("A letra {0} já foi tentada/n", letter[0]);
                        continue;
                    }
                    else
                    {
                        triedLetters.Add(letter[0]);
                    }

                    bool found = w.Guess(letter[0]);

                    if (found)
                    {
                        Console.WriteLine("Parabens! A letra{0} foi encontrada!", letter[0]);
                    }
                    else
                    {
                        errors++;
                        Console.WriteLine("Sinto muito, a letra {0} não existe na palavra. Você errou {1} vez(es).", letter[0], errors);
                    }
                    Console.WriteLine();
                }

                if (errors < maxErrors)
                {
                    Console.WriteLine("/nVocê adivinhou a palavra: {0}. Deseja jogar mais uma vez? (S/N): ", w.CompleteWord);
                }

                string playAgain = Console.ReadLine();

                if (playAgain.Length > 0 && (playAgain[0] == 's' || playAgain[0] == 'S'))
                {
                    Console.WriteLine("OK, vamos jogar novamente!");

                    w.Next();

                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Tchau!");
                    break;
                }
            }

        }
    }
}
