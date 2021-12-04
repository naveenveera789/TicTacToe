using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    public class TicTacToeGame
    {
        char[] board = new char[10];
        public void Board()
        {
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
        public void Display()
        {
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", board[1], board[2], board[3]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", board[4], board[5], board[6]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", board[7], board[8], board[9]);
            Console.WriteLine("     |     |     ");
        }
    }
}