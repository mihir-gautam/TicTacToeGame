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
    }
}
