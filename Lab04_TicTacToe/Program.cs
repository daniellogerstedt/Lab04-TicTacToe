using System;

namespace Lab04_TicTacToe
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            PlayGame();
        }

        /// <summary>
        /// This method plays the game.
        /// </summary>
        static void PlayGame()
        {
            // DONE: Setup your game here. Create an introduction. 
            // Create your players, and instantiate your Game class. 
            // output to the console the winner

            Console.WriteLine("Player One Enter A Name");
            string playerOneName = Console.ReadLine();

            Console.WriteLine("Player Two Enter A Name");
            string playerTwoName = Console.ReadLine();

            Classes.Player playerOne = new Classes.Player();
            playerOne.Marker = "X";
            playerOne.Name = playerOneName;
            playerOne.IsTurn = true;

            Classes.Player playerTwo = new Classes.Player();
            playerTwo.Marker = "O";
            playerTwo.Name = playerTwoName;
            playerTwo.IsTurn = false;

            Classes.Game theGame = new Classes.Game(playerOne, playerTwo);

            Classes.Player winner = theGame.Play();

            Console.WriteLine($"{winner.Name} is the winner!");

        }
    }
}
