using System;

namespace TicTacToeProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to TicTacToe Game");
            TicTacToeGame Game = new TicTacToeGame();
            Game.TicTacToeBoard();
            Game.myChoice();
            Game.ShowBoard();
            Game.isPossible();
        }
    }
}
