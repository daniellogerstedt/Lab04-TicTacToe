using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04_TicTacToe.Classes
{
    public class Board
    {
		/// <summary>
		/// Tic Tac Toe Gameboard states
		/// </summary>
		public string[,] GameBoard = new string[,]
		{
			{"1", "2", "3"},
			{"4", "5", "6"},
			{"7", "8", "9"},
		};

        /// <summary>
        /// Displays the current status of the board by writing it to the console line by line. Formats the board so that it is readable.
        /// </summary>
		public void DisplayBoard()
		{
            int numberOfRows = GameBoard.GetLength(0);
            int sizeOfRows = GameBoard.GetLength(1);

            //DONE: Output the board to the console
            Console.Clear();
            
            for (int i = 0; i < numberOfRows; i++)
            {
                StringBuilder boardRowBuilder = new StringBuilder();
                StringBuilder boardRowBreakBuilder = new StringBuilder();

                for (int j = 0; j < sizeOfRows; j++)
                {
                    boardRowBuilder.Append(GameBoard[i, j]);

                    if (j < sizeOfRows - 1)
                    {
                        boardRowBuilder.Append(" | ");
                    }
                    boardRowBreakBuilder.Append("---");
                }

                Console.WriteLine(boardRowBuilder.ToString());

                if (i < numberOfRows - 1 )
                {
                    Console.WriteLine(boardRowBreakBuilder.ToString());
                }

            }
		
		}
	}
}
