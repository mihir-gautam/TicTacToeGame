using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeProgram
{
    class TicTacToeGame
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
                return false;
            }
        }
        public void makeAMove(int index)
        {
            board[index] = myChoice();
        }
    }
}
