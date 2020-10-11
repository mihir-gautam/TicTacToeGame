using System;

namespace TicTacToeProgram
{
    class Program
    {
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
            char userChoice = Game.myChoice();
            char compChoice;
            if (userChoice == 'X')
                compChoice = '0';
            else
                compChoice = 'X';
            Game.ShowBoard();
            Game.GamePlay(userChoice, compChoice);
            
        }
    }
}
