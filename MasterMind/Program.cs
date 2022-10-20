using System;
using System.Collections.Generic;
using MasterMindLibrary;


namespace MasterMind
{
    class Program
    {
        static List<Peg> pegList = new List<Peg>()
        {
            new Peg(ConsoleColor.White, ConsoleColor.Red),
            new Peg(ConsoleColor.White, ConsoleColor.Blue),
            new Peg(ConsoleColor.Black, ConsoleColor.Green),
            new Peg(ConsoleColor.Black, ConsoleColor.Yellow),
            new Peg(ConsoleColor.Black, ConsoleColor.Cyan),
            new Peg(ConsoleColor.White, ConsoleColor.Magenta),
            new Peg(ConsoleColor.White, ConsoleColor.DarkGray),
            new Peg(ConsoleColor.White, ConsoleColor.DarkRed)
        };

        static void Main(string[] args)
        {
            List<Attempt> allAttempts = new List<Attempt>();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Welcome to Mastermind!");
            Console.ResetColor();

            //ask for difficulty
            Console.WriteLine("Choose a difficulty");
            int difficulty = MMLib.GetConsoleMenu(new List<string> { "Easy: 4 colors", "Medium: 6 colors", "Hard: 8 colors" });

            //ask for maxTurns of turns to guess it
            int maxTurns = MMLib.GetConsoleInt("How many attempts (1-50)?", 1, 50);

            //store the maxPegs based on difficulty
            int maxPegs = 2 + 2 * difficulty;
            //Generate an answer
            List<int> answer = MMLib.GenerateAnswer(maxPegs);

            //show cheat? 
            MMLib.Cheat(answer, pegList);

            //loop while !gameWon && maxTurns != 0
            //  get user attempt
            //  Check the attempt for a correct guess
            //  add the attempt to the attempt list
            //  determin if the game has been won or not
            //  reduce the maxTurns
            bool gameWon = false;
            do
            {
                Attempt attempt = GetAttemptFromUser(maxPegs, allAttempts, maxTurns);
                CheckAttempt(attempt, answer);
                allAttempts.Add(attempt);
                if (attempt.CorrectAnswerCount == maxPegs) gameWon = true;
                maxTurns--;

            } while (!gameWon && maxTurns != 0);

            //If won, display Game Won!
            //If lost, show game loss
            //show the correct answer
            if (gameWon)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("You Win!");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("You Loose!");
            }
            MMLib.ShowAnswer(answer, pegList, "c");
        }

        static Attempt GetAttemptFromUser(int maxPegs, List<Attempt> allAttempts, int maxTurns)
        {
            //Create a new Attempt
            //Get color options based on maxPegs
            //Loop of # of pegs they need to choose
            //      clear console
            //      Display # of attempts left
            //      Show all previous attempts
            //      Show pegs they have chosen already in this attempt
            //      Ask them to pick a peg color from a menu of options
            //      Add the chosen peg to the Attempt.AttemptList
            //Return the attempt when done

            Attempt attempt = new Attempt();
            List<string> colors = MMLib.GetColorOptions(maxPegs, pegList);
            for (int i = 0; i < maxPegs; i++)
            {
                Console.Clear();
                Console.WriteLine($"{maxTurns} attempts left");
                MMLib.ShowAttempts(allAttempts, pegList, "c");
                MMLib.ShowChosenPegs(attempt, pegList);
                Console.WriteLine("Choose a color:");
                int peg = MMLib.GetConsoleMenu(colors);
                attempt.AttemptList.Add(peg - 1);
            }
            return attempt;
        }


        static void CheckAttempt(Attempt attempt, List<int> answer)
        {
            //Check the attempt.AttemptList to see if they got a match to the answer
            //If a peg is correct, increment the attempt.CorrectAnswerCount
            for (int i = 0; i < answer.Count; i++)
            {
                if (attempt.AttemptList[i] == answer[i])
                {
                    attempt.CorrectAnswerCount++;
                }
            }
        }
    }
}
