using System;
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
            Console.WriteLine("  1" + board[1] + "  |  2" + board[2]+  "  |  3" + board[3] + "  ");
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
                isPossible(index); 
                return false;
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
        public bool isWinner(char[] b, char ch)
        {
            return (b[1] == ch && b[2] == ch && b[3] == ch) ||
                    (b[4] == ch && b[5] == ch && b[6] == ch) ||
                    (b[7] == ch && b[8] == ch && b[9] == ch) ||
                    (b[1] == ch && b[4] == ch && b[7] == ch) ||
                    (b[2] == ch && b[5] == ch && b[8] == ch) ||
                    (b[3] == ch && b[6] == ch && b[9] == ch) ||
                    (b[1] == ch && b[5] == ch && b[9] == ch) ||
                    (b[7] == ch && b[5] == ch && b[3] == ch);
        }
        public void PlayerMovement(char choice)
        {
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
        public void ComputerMovement(char compChoice)
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
                ComputerMovement(compChoice);
            }
        }
        public void GamePlay(char userChoice, char compChoice)
        {
            Player player = Toss();
            bool winner = false;
            while (winner==false)
            {
                if (player.Equals(Player.USER))
                {
                    PlayerMovement(userChoice);
                    player = Player.COMPUTER;
                }
                else
                {
                    ComputerMovement(compChoice);
                    player = Player.USER;
                }
                char userLetter = myChoice();
                winner = isWinner(board, userLetter);
                if (winner == true)
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
                }
                else 
                {
                    Console.WriteLine("Game draw");
                    break;
                }
            }
        }
    }
}
