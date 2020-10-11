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
            Game.ShowBoard();
            char userChoice=Game.myChoice();
            char compChoice;
            if (userChoice == 'X')
            compChoice = 'O';
            else
                compChoice = 'X';
            Game.GamePlay(userChoice, compChoice);
        }
    }
}
