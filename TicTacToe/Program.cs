using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic Tac Toe Game");
            TicTacToeGame game = new TicTacToeGame();
            char[] board = game.Board();
            char player = game.PlayerChoosing();
            game.Display();
            game.Position(player);
            game.Display();
        }
    }
}