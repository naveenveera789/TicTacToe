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
            for(int i = 0; i < board.Length; i++)
            {
                board[i] = ' ';
            }
        }
    }
}