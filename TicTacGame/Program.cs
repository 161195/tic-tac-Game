using System;

namespace TicTacGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // Main method
            Console.WriteLine("Welcome to The tic tac toe Game");
            TicTacToeGame game1 = new TicTacToeGame();
            game1.createGame();

            Console.WriteLine("Game Begins.\nPlease select your letter");
            game1.selectLetter();


        }
    }
}
