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
            Console.WriteLine("Enter your choice: x or o");
            string mychoice = Console.ReadLine();
            char Computer;
            if (mychoice == "x")
            {
                Computer = 'o';
            }
            else
            {
                Computer = 'x';
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
            if (board[index] == ' ' && index > 1 && index < 10)
            {
                Console.WriteLine("Possible to move at this location");
                return true;
            }
            else if(index < 0 || index > 9)
            {
                Console.WriteLine("Enter valid position");
                return false;
            }
            else
            {
                return false;
            }
        }
    }
}
