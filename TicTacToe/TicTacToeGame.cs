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
            char input = char.ToUpper(player);         
            if (input == 'X')
            {
                char computer = 'O';
                Console.WriteLine("Player : " + input);
                Console.WriteLine("Computer : " + computer);
            }
            if (input == 'O')
            {
                char computer = 'X';
                Console.WriteLine("Player : " + input);
                Console.WriteLine("Computer : " + computer);
            }
        }
    }
}