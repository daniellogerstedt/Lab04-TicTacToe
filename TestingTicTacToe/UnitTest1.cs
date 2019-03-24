using Xunit;
using Lab04_TicTacToe.Classes;

namespace TestingTicTacToe
{
    public class UnitTest1
    {

        [Theory]
        [InlineData(1, 0, 0)]
        [InlineData(2, 0, 1)]
        [InlineData(3, 0, 2)]
        [InlineData(4, 1, 0)]
        [InlineData(5, 1, 1)]
        [InlineData(6, 1, 2)]
        [InlineData(7, 2, 0)]
        [InlineData(8, 2, 1)]
        [InlineData(9, 2, 2)]
        public void TestGetPosition(int input, int row, int column)
        {
            Position testPosition = Player.PositionForNumber(input);
            Assert.Equal(testPosition.Row, row);
            Assert.Equal(testPosition.Column, column);
        }

        [Fact]
        public void TestSwitchPlayer()
        {
            Player playerOne = new Player();
            playerOne.Marker = "X";
            playerOne.Name = "testOne";
            playerOne.IsTurn = true;

            Player playerTwo = new Player();
            playerTwo.Marker = "O";
            playerTwo.Name = "testTwo";
            playerTwo.IsTurn = false;

            Game testGame = new Game(playerOne, playerTwo);

            testGame.SwitchPlayer();
            Assert.True(playerTwo.IsTurn);
            Assert.False(playerOne.IsTurn);
        }

        [Fact]
        public void TestCheckForWinnerWithWinner()
        {
            string[,] winningBoard = new string[,]
            {
                { "1", "O", "X" },
                { "O", "O", "X" },
                { "7", "X", "X" }
            };
            Player playerOne = new Player();
            playerOne.Marker = "X";
            playerOne.Name = "testOne";
            playerOne.IsTurn = true;

            Player playerTwo = new Player();
            playerTwo.Marker = "O";
            playerTwo.Name = "testTwo";
            playerTwo.IsTurn = false;

            Game testGame = new Game(playerOne, playerTwo);

            
            testGame.Board.GameBoard = winningBoard;

            bool actual = testGame.CheckForWinner(testGame.Board);
            Assert.True(actual);
        }

        [Fact]
        public void TestCheckForWinnerWithoutWinner()
        {
            string[,] winningBoard = new string[,]
            {
                { "X", "O", "X" },
                { "O", "O", "X" },
                { "X", "X", "O" }
            };
            Player playerOne = new Player();
            playerOne.Marker = "X";
            playerOne.Name = "testOne";
            playerOne.IsTurn = true;

            Player playerTwo = new Player();
            playerTwo.Marker = "O";
            playerTwo.Name = "testTwo";
            playerTwo.IsTurn = false;

            Game testGame = new Game(playerOne, playerTwo);

            
            testGame.Board.GameBoard = winningBoard;

            bool actual = testGame.CheckForWinner(testGame.Board);
            Assert.False(actual);
        }
        
    }
}
