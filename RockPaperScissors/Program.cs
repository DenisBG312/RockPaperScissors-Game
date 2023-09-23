using static System.Net.Mime.MediaTypeNames;

namespace RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // INPUTS 
            Console.Write("You can choose between: [r]ock, [p]aper, [s]cissors: ");
            Console.WriteLine();
            Console.WriteLine("Write 'End Game' to view the final points.");
            Console.WriteLine("The valid inputs are: [r], [p], [s]");
            // PLAYER LOGIC 
            Console.Write("Choose a move: ");
            string input = Console.ReadLine(); // input refers to -> player move
            int playerScore = 0;
            int computerScore = 0;

            // STARTING THE GAME
            while (input != "End Game")
            {
                const string Rock = "Rock";
                const string Paper = "Paper";
                const string Scissors = "Scissors";
                if (input == "r")
                {
                    input = Rock;
                    Console.WriteLine("You chose Rock");
                }
                else if (input == "p")
                {
                    input = Paper;
                    Console.WriteLine("You chose Paper");
                }
                else if (input == "s")
                {
                    input = Scissors;
                    Console.WriteLine("You chose Scissors");
                }
                else
                {
                    Console.WriteLine("Invalid input. Try again...");
                    input = Console.ReadLine();
                    continue;
                }

                // COMPUTER LOGIC //
                Random random = new Random();
                int computerRandomNumber = random.Next(1, 4);
                string computerMove = "";
                switch (computerRandomNumber)
                {
                    case 1:
                        computerMove = Rock;
                        break;
                    case 2:
                        computerMove = Paper;
                        break;
                    case 3:
                        computerMove = Scissors;
                        break;
                }
                Console.WriteLine($"The computer chose {computerMove}");

                // WINNER LOGIC //
                if (input == Rock)
                {
                    if (computerMove == Rock)
                    {
                        Console.WriteLine("Draw.");
                    }
                    else if (computerMove == Paper)
                    {
                        Console.WriteLine("You lose.");
                        computerScore++;
                    }
                    else if (computerMove == Scissors)
                    {
                        Console.WriteLine("You win.");
                        playerScore++;
                    }
                }
                if (input == Paper)
                {
                    if (computerMove == Rock)
                    {
                        Console.WriteLine("You win.");
                        playerScore++;
                    }
                    else if (computerMove == Paper)
                    {
                        Console.WriteLine("Draw.");
                    }
                    else if (computerMove == Scissors)
                    {
                        Console.WriteLine("You lose.");
                        computerScore++;
                    }
                }
                if (input == Scissors)
                {
                    if (computerMove == Rock)
                    {
                        Console.WriteLine("You lose.");
                        computerScore++;
                    }
                    else if (computerMove == Paper)
                    {
                        Console.WriteLine("You win.");
                        playerScore++;
                    }
                    else if (computerMove == Scissors)
                    {
                        Console.WriteLine("Draw.");
                    }
                }
                Console.WriteLine($"Player has {playerScore} points and the computer has {computerScore} points");
                input = Console.ReadLine(); // --> checks if the input is End of Game
            }
            string winner = "";
            if (input == "End Game")
            {
                Console.WriteLine();
                Console.WriteLine($"Total points:");
                Console.WriteLine($"Player: {playerScore}, Computer: {computerScore}");
                if (playerScore > computerScore)
                {
                    Console.WriteLine($"Congrats! You are the winner.");
                }
                else if (playerScore < computerScore)
                {
                    winner = "Computer";
                    Console.WriteLine($"{winner} is the winner!");
                }
                else if (playerScore == computerScore)
                {
                    Console.WriteLine($"The result is Draw!");
                }
            }
        }
    }
}