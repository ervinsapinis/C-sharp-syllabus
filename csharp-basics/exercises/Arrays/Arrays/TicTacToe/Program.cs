using System;
using System.Runtime.InteropServices;

namespace TicTacToe
{
    class Program
    {
        private static char[,] board = new char[3, 3];
        public static bool gameIsRunning = true;

        private static void Main(string[] args)
        {
            int playerTurn = 1;
            char playerSymbol = 'X';
            InitBoard();

            while (gameIsRunning)
            {
                Console.Clear();
                DisplayBoard();
                Console.Write($"{playerSymbol}, choose your location (row, column): ");
                var playerInputRow = int.Parse(Console.ReadKey().KeyChar.ToString());
                var playerInputColumn = int.Parse(Console.ReadKey().KeyChar.ToString());
                Console.WriteLine();
                board[playerInputRow, playerInputColumn] = playerSymbol;
                Console.Clear();
                DisplayBoard();

                if (playerTurn == 9)
                {
                    Console.Clear();
                    DisplayBoard();
                    Console.WriteLine("It's a tie.");
                    break;
                }   

                if (playerSymbol == board[0, 0] && playerSymbol == board[0, 1] && playerSymbol == board[0, 2] ||
                    playerSymbol == board[1, 0] && playerSymbol == board[1, 1] && playerSymbol == board[1, 2] ||
                    playerSymbol == board[2, 0] && playerSymbol == board[2, 1] && playerSymbol == board[2, 2] ||
                    playerSymbol == board[0, 0] && playerSymbol == board[1, 0] && playerSymbol == board[2, 0] ||
                    playerSymbol == board[0, 0] && playerSymbol == board[1, 0] && playerSymbol == board[2, 0] ||
                    playerSymbol == board[0, 1] && playerSymbol == board[1, 1] && playerSymbol == board[2, 1] ||
                    playerSymbol == board[0, 2] && playerSymbol == board[1, 2] && playerSymbol == board[2, 2] ||
                    playerSymbol == board[0, 0] && playerSymbol == board[1, 1] && playerSymbol == board[2, 2] ||
                    playerSymbol == board[0, 2] && playerSymbol == board[1, 1] && playerSymbol == board[2, 0])
                    WinMessage(playerSymbol);

                playerTurn++;
                playerSymbol = playerTurn % 2 == 0 ? 'O' : 'X';
            }
        }

        public static void WinMessage(char playerSymbol)
        {
            Console.Clear();
            DisplayBoard();
            Console.WriteLine($"Congratulations {playerSymbol}, you have won the game.");
            Console.ReadKey();
            gameIsRunning = false;
        }

        private static void InitBoard()
        {
            // fills up the board with blanks
            for (var r = 0; r < 3; r++)
            {
                for (var c = 0; c < 3; c++)
                    board[r, c] = ' ';
            }
        }

        private static void DisplayBoard()
        {
            Console.WriteLine("  0  " + board[0, 0] + "|" + board[0, 1] + "|" + board[0, 2]);
            Console.WriteLine("    --+-+--");
            Console.WriteLine("  1  " + board[1, 0] + "|" + board[1, 1] + "|" + board[1, 2]);
            Console.WriteLine("    --+-+--");
            Console.WriteLine("  2  " + board[2, 0] + "|" + board[2, 1] + "|" + board[2, 2]);
            Console.WriteLine("    --+-+--");
        }
    }
}
