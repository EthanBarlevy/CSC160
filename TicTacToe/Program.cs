namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create the game board
            char[,] board = { { ' ', ' ', ' ' }, { ' ', ' ', ' ' }, { ' ', ' ', ' ' } };

            // create an array of player names
            string[] names = { "Player 1", "Player 2" };

            // create an array of player symbols
            char[] symbols = { 'X', 'O' };

            // end game flag
            bool done = false;

            // player turn
            int turn = 0;

            // completed turn counter
            int totalTurns = 0;

            // tie flag
            bool tie = false;

            // start game loop
            do
            {
                // i refuse to put all of the code in main
                DisplayBoard(board);
                NextTurn(names, ref turn, ref board, symbols, ref totalTurns);
                done = DisplayEnding(CheckWin(board, symbols[turn], totalTurns, ref tie), names, turn, tie, board);
                if (turn == 0) { turn++; }
                else { turn--; }

            } while (!done);
        }

        static void DisplayBoard(char[,] b) 
        {
            Console.WriteLine();
            for (int row = 0; row < b.GetLength(0); row++)
            {
                for (int col = 0; col < b.GetLength(1); col++)
                {
                    Console.Write(" {0} ", b[row, col]);
                    if (col != b.GetLength(1) - 1)
                    { 
                        Console.Write("|");
                    }
                }
                if (row != b.GetLength(0) - 1)
                { 
                    Console.WriteLine();
                    Console.WriteLine("-----------");
                }
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        static void NextTurn(string[] name, ref int turn, ref char[,] board, char[] symbols, ref int total)
        {
            int row, col;
            bool valid = false;
            do
            {
                Console.WriteLine("{0}, enter row (1-3): ", name[turn]);
                bool valRow = int.TryParse(Console.ReadLine(), out row);

                Console.WriteLine("{0}, enter col (1-3): ", name[turn]);
                bool valCol = int.TryParse(Console.ReadLine(), out col);

                if (valRow && valCol)
                { 
                    if (row > 3 || row < 0 || col > 3 || col < 0)
                    {
                        valRow = false;
                    }
                    else if (board[row - 1, col - 1] != ' ')
                    {
                        valCol = false;
                    }
                }

                if (valRow && valCol)
                {
                    valid = true;
                    board[row - 1, col - 1] = symbols[turn];
                    total++;
                }
                else
                {
                    Console.WriteLine("Incorrect row or column. Please try again.");
                }

            } while (!valid);
        }

        static bool CheckWin(char[,] board, char symbol, int total, ref bool tie)
        {
            bool won = false;
            short winCount = 0;
            // horizontal
            for (short row = 0; row < board.GetLength(0); row++)
            {
                for (short col = 0; col < board.GetLength(1); col++)
                {
                    if (board[row, col] == symbol)
                    { 
                        winCount++;
                    }
                }
                if (winCount == 3)
                {
                    won = true;
                }
                winCount = 0;
            }

            // vertical
            for (short col = 0; col < board.GetLength(0); col++)
            {
                for (short row = 0; row < board.GetLength(1); row++)
                {
                    if (board[row, col] == symbol)
                    {
                        winCount++;
                    }
                }
                if (winCount == 3)
                {
                    won = true;
                }
                winCount = 0;
            }

            // diagonal
            // ugh why i dont want to
            // this will be harcoded because screw this
            if (!won)
            {
                if (board[0, 0] == symbol)
                {
                    winCount++;
                }
                if (board[1, 1] == symbol)
                {
                    winCount++;
                }
                if (board[2, 2] == symbol)
                {
                    winCount++;
                }
                if (winCount == 3)
                {
                    won = true;
                }
                winCount = 0;
                if (board[2, 0] == symbol)
                {
                    winCount++;
                }
                if (board[1, 1] == symbol)
                {
                    winCount++;
                }
                if (board[0, 2] == symbol)
                {
                    winCount++;
                }
                if (winCount == 3)
                {
                    won = true;
                }
            }

            // tie
            if (total == 9 && !won)
            {
                tie = true;
            }

            return won;
        }

        static bool DisplayEnding(bool win, string[] names, int turn, bool tie, char[,] b)
        {
            if (win || tie)
            {
                DisplayBoard(b);
            }
            if (win && !tie)
            {
                Console.WriteLine("{0} Wins!", names[turn]);
                return true;
            }
            if (tie)
            {
                Console.WriteLine("Cats Game");
                return true;
            }
            return false;
        }
    }
}
