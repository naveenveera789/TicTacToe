using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    public class TicTacToeGame
    {
        public void Board()
        {
            char[] board = new char[10];
            for(int i = 1; i < board.Length; i++)
            {
                board[i] = ' ';
            }
        }
        public void PlayerChoosing()
        {
            Console.WriteLine("Choose X or O for playing the game : ");
            char player = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Player : " + player);
            if (player == 'X' || player == 'x')
            {
                char computer = 'O';
                Console.WriteLine("Computer : " + computer);
            }
            if (player == 'O' || player == 'o')
            {
                char computer = 'X';
                Console.WriteLine("Computer : " + computer);
            }
        }
    }
}