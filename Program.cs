using System;

namespace TicTacToeProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to TicTacToe Game");
            TicTacToeGame Game = new TicTacToeGame();
            int gameNumber = 1;
            while (gameNumber == 1)
            { 
                Game.TicTacToeBoard();
                Game.ShowBoard();
                char userChoice = Game.myChoice();
                char compChoice;
                if (userChoice == 'X')
                    compChoice = 'O';
                else
                    compChoice = 'X';
                Game.ShowBoard();
                Game.GamePlay(userChoice, compChoice);
                Console.WriteLine("Do you want to play another game? \n1. Yes\n2. No");
                gameNumber = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
