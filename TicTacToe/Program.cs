namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create the game board
            char[,] board = new char[3, 3];

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
                DisplayBoard(board);
                NextTurn(names, turn, board, symbols);
                CheckWin(board, symbols[turn]);
                DisplayEnding();

            } while (!done);
        }

        static void DisplayBoard(char[,] b) 
        {
            Console.WriteLine();
            for (int row = 0; row < b.GetLength(0); row++)
            {
                for (int col = 0; col < b.GetLength(1); col++)
                {
                    Console.WriteLine(" {0} ", b[row, col]);
                    Console.WriteLine("|"); // i knew that this wouldnt work
                }
                if (row != b.GetLength(0) - 1)
                { 
                    Console.WriteLine("-----------");
                }
            }
        }

        static void NextTurn(string[] name, int turn, char[,] board, char[] symbols)
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
                    valid = true;
                    board[row-1, col-1] = symbols[turn];
                }
                else
                {
                    Console.WriteLine("Incorrect row or column. Please try again.");
                }

            } while (!valid);
        }

        static bool CheckWin(char[,] board, char symbol)
        {
            if (board[0, 0] == symbol)
            { 
                 // unfinished this is just hard coded rn
            }
            return false;
        }

        static void DisplayEnding()
        { 
            
        }
    }
}
