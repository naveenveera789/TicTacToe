using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    public class TicTacToeGame
    {
        char[] board = new char[10];
        public char[] Board()
        {
            for (int i = 1; i < board.Length; i++)
            {
                board[i] = ' ';
            }
            return board;
        }
        public char PlayerChoosing()
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
            return player;
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
        public void Position(char player)
        {
            char input = char.ToUpper(player);
            Console.WriteLine("Enter Position from 1 to 9 : ");
            int pos = Convert.ToInt32(Console.ReadLine());
            if (board[pos] == ' ')
            {
                board[pos] = input;
                return;
            }
        }
    }
}
