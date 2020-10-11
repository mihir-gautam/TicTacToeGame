using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeProgram
{
    public class TicTacToeGame
    {
        char[] board = new char[10];
        
        public void TicTacToeBoard()
        {
            for (int i = 1; i < board.Length; i++)
            {
                board[i] = ' ';
            }
        }
        public char myChoice()
        {
            Console.WriteLine("Your choice X or O");
            string mychoice = Console.ReadLine();
            char Computer;
            if (mychoice == "X")
            {
                Computer = 'O';
            }
            else
            {
                Computer = 'X';
            }
            Console.WriteLine("Succeed");
            return Computer;
        }
        public void ShowBoard()
        {
            Console.WriteLine("  1  |  2  |  3  ");
            Console.WriteLine(" --------------- ");
            Console.WriteLine("  4  |  5  |  6 ");
            Console.WriteLine(" --------------- ");
            Console.WriteLine("  7  |  8  |  9 ");
        }
        public bool isPossible()
        {
            Console.WriteLine("Enter the index (from 1 to 9) for the move");
            int index = Convert.ToInt32(Console.ReadLine());
            if (board[index] == ' ')
            {
                return true;
            }
            else
            {
                Console.WriteLine("Sorry, position is already occupied. \n Select any other position");
                return false;
                Console.WriteLine("Enter the index (from 1 to 9) for the move");
                isPossible();
            }
        }
        public enum Player { USER, COMPUTER };
        public Player Toss()
        {
            Random random = new Random();
            int toss = random.Next(0, 2);
            int callForToss = Convert.ToInt32(Console.ReadLine());
            if (toss == callForToss)
            {
                Console.WriteLine("Congratulations! You won the toss.");
                return Player.USER;
            }
            else
            {
                Console.WriteLine("Unfortunately, you lost the toss, Computer will play first.");
                return Player.COMPUTER;
            }
        }
    }
}
