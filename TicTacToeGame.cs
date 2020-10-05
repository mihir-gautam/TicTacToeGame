using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeProgram
{
    class TicTacToe
    {
        char[] board = new char[10];

        public void TicTacToeGame()
        {
            for (int i = 1; i < 10; i++)
            {
                board[i] = ' ';
            }

        }

    }
}
