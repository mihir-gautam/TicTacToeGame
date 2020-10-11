using System;

namespace TicTacToeProgram
{
    class Program
    {
        public const int HEAD = 0;
        public const int TAIL = 1;
        public static char[] board = new char[10];
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to TicTacToe Game");
            TicTacToeGame Game = new TicTacToeGame();
            Console.WriteLine("Game will start after the Toss, Enter \n1.HEAD \n2.TAIL");
            Game.Toss();
            Game.TicTacToeBoard();
            Game.ShowBoard();
            Console.WriteLine("Enter the index (from 1 to 9) for the move");
            int index = Convert.ToInt32(Console.ReadLine());
            Game.isPossible(index);
            Game.myChoice();
            char userLetter = Game.myChoice(); 
            Console.WriteLine("Check if you won: " + Game.isWinner(board, userLetter));
        }
    }
}
