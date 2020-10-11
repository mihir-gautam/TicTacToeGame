using System;

namespace TicTacToeProgram
{
    class Program
    {
        public const int HEAD = 0;
        public const int TAIL = 1;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to TicTacToe Game");
            TicTacToeGame Game = new TicTacToeGame();
            Console.WriteLine("Game will start after the Toss, Enter \n1.HEAD \n2.TAIL");
            Game.Toss();
            Game.TicTacToeBoard();
            Game.ShowBoard();
            Game.isPossible();
            Game.myChoice(); 
        }
    }
}
