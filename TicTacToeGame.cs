﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeProgram
{
    public class TicTacToeGame
    {
        public char[] board = new char[10];

        public void TicTacToeBoard()
        {
            for (int i = 1; i < 10; i++)
            {
                board[i] = ' ';
            }
        }
        public char myChoice()
        {
            Console.WriteLine("Your choice X or O");
            char mychoice = Convert.ToChar(Console.ReadLine());
            char Computer;
            if (mychoice == 'X')
            {
                Computer = 'O';
            }
            else
            {
                Computer = 'X';
            }
            Console.WriteLine("Succeed");
            return mychoice;
        }
        public void ShowBoard()
        {
            Console.WriteLine("  1" + board[1] + "  |  2" + board[2] + "  |  3" + board[3] + "  ");
            Console.WriteLine(" --------------- ");
            Console.WriteLine("  4" + board[4] + "  |  5" + board[5] + "  |  6" + board[6] + "  ");
            Console.WriteLine(" --------------- ");
            Console.WriteLine("  7" + board[7] + "  |  8" + board[8] + "  |  9" + board[9] + "  ");
        }
        public bool isPossible(int index)
        {
            if (board[index] == ' ')
            {
                return true;
            }
            else
            {
                Console.WriteLine("Sorry, position is already occupied. \n Select any other position");
                Console.WriteLine("Select the position you want to play on");
                return false;
            }
        }
        public enum Player { USER, COMPUTER };
        public Player Toss()
        {
            Random random = new Random();
            int toss = random.Next(1, 3);
            Console.WriteLine("Game will start after the Toss, Enter \n1.HEAD \n2.TAIL");
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
        public bool isWinner(char ch)
        {
            return (board[1] == ch && board[2] == ch && board[3] == ch) ||
                    (board[4] == ch && board[5] == ch && board[6] == ch) ||
                    (board[7] == ch && board[8] == ch && board[9] == ch) ||
                    (board[1] == ch && board[4] == ch && board[7] == ch) ||
                    (board[2] == ch && board[5] == ch && board[8] == ch) ||
                    (board[3] == ch && board[6] == ch && board[9] == ch) ||
                    (board[1] == ch && board[5] == ch && board[9] == ch) ||
                    (board[7] == ch && board[5] == ch && board[3] == ch);
        }
        public void PlayerMovement(char choice)
        {
            Console.WriteLine("Enter the position where you want to play");
            int userChoice = Convert.ToInt32(Console.ReadLine());
            if (isPossible(userChoice))
            {
                board[userChoice] = choice;
                Console.WriteLine("Succeed");
                ShowBoard();
            }
            else
            {
                Console.WriteLine("Position already occupied");
                Console.WriteLine("Try Again");
                PlayerMovement(choice);
            }
        }
        public void ComputerMovement(char compChoice, char userChoice)
        {
            int compWinMove = WinningMove(compChoice);
            if (compWinMove == 0)
            {
                int userWinMove = WinningMove(userChoice);
                if (userWinMove == 0)
                {
                    if ((CornerMove() == 0))
                    {
                        if (isPossible(5) == false)
                        {
                            Random random = new Random();
                            int computerChoice = random.Next(1, 10);
                            if (isPossible(computerChoice))
                            {
                                board[computerChoice] = compChoice;
                                ShowBoard();
                            }
                            else
                            {
                                ComputerMovement(compChoice, userChoice);
                            }
                        }
                        else
                        {
                            board[5] = compChoice;
                            ShowBoard();
                        }
                    }
                    else
                    {
                        board[CornerMove()] = compChoice;
                        ShowBoard();
                    }
                }
                else
                {
                    board[userWinMove] = compChoice;
                    ShowBoard();
                }
            }
            else
            {
                board[compWinMove] = compChoice;
                ShowBoard();
            }
        }
        public int WinningMove(char choice)
        {
            int winningIndex = 0;
            for (int i = 1; i < 10; i++)
            {
                if (isPossible(i) == true)
                {
                    board[i] = choice;
                    if (isWinner('X') == true || isWinner('O') == true)
                    {
                        board[i] = ' ';
                        winningIndex = i;
                        break;
                    }
                    else
                    {
                        board[i] = ' ';
                        winningIndex = 0;
                        continue;
                    }
                }
                else
                    continue;
            }
            return winningIndex;
        }
        public void GamePlay(char userChoice, char compChoice)
        {
            Player player = Toss();
            while (isWinner('X') == false || isWinner('O') == false)
            {
                if (player.Equals(Player.USER))
                {
                    PlayerMovement(userChoice);
                    player = Player.COMPUTER;
                }
                else
                {
                    ComputerMovement(compChoice, userChoice);
                    player = Player.USER;
                }
                if (isWinner('X')||isWinner('O'))
                {
                    if (player == Player.USER)
                    {
                        Console.WriteLine("Computer won");
                        break;
                    }
                    if (player == Player.COMPUTER)
                    {
                        Console.WriteLine("User won");
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }
        public int CornerMove()
        {
            int[] corners = { 1, 3, 7, 9 };
            int freeCorner = 0;
            foreach (int i in corners)
            {
                if (isPossible(i) == true)
                {
                    freeCorner = i;
                    break;
                }
                else
                    continue;
            }
            return freeCorner;
        }
    }
}