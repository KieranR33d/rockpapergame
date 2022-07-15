using System;

namespace rockpaperscissors
{
    class Game
    {
        static void Main(string[] args)

        {
            bool keepPlaying = true;
            while (keepPlaying)
            {
                string userInput, systemInput;

            int randomNum;

            Console.WriteLine("Rock Paper or Scissors?");

            userInput = Console.ReadLine();

            Random rnd = new Random();

            randomNum = rnd.Next(1, 4);

                int Wins = 0;
                int Loses = 0;
                int Draws = 0;
                Console.WriteLine("Would you like to continue playing? (Y/N)");

                string Loop = Console.ReadLine();
                if (Loop == "Y")
                {
                    keepPlaying = true;
                }
                else if (Loop == "N")
                {
                    keepPlaying = false;
                }
                else
                {

                }
                
                
                    switch (randomNum)
                    {
                        case 1:

                            systemInput = "Rock";

                            Console.WriteLine("the computer has chosen rock");

                            if (userInput == "Rock")
                            {
                                Console.WriteLine("It's a draw");
                                Draws++;
                            }
                            else if (userInput == "Paper")
                            {
                                Console.WriteLine("You Loose");
                                Loses++;
                            }
                            else
                            {
                                Console.WriteLine("You win");
                                Wins++;
                            }
                            break;

                    case 2:

                            systemInput = "Paper";

                            Console.WriteLine("the computer has chosen paper");

                            if (userInput == "Rock")
                            {
                                Console.WriteLine("You Lose");
                                Loses++;
                            }
                            else if (userInput == "Paper")
                            {
                                Console.WriteLine("It's a draw");
                                Draws++;
                            }
                            else
                            {
                                Console.WriteLine("You Win");
                                Wins++;
                            }
                            break;

                        case 3:

                            systemInput = "Scissors";

                            Console.WriteLine("the computer has chosen paper");

                            if (userInput == "Rock")
                            {
                                Console.WriteLine("You Win");
                                Wins++;
                            }
                            else if (userInput == "Paper")
                            {
                                Console.WriteLine("You Lose");
                                Loses++;
                            }
                            else
                            {
                                Console.WriteLine("It's a draw");
                                Draws++;
                            }
                            break;

                        default:

                            Console.WriteLine("please enter a valid choice");

                            break;
                    }

                    Console.WriteLine("Scores: \tWins: \t{0}, \tLoses : \t{1}, \tDraws : \t{2}", Wins, Loses, Draws);



            }

        }

    }
}

