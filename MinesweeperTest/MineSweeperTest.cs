using NUnit.Framework;
using Minesweeper;
namespace MinesweeperTest
{
    public class MineSweeperTest
    {
        private MineSweeper _mineSweeper;

        [SetUp]
        public void Setup()
        {
            _mineSweeper = new MineSweeper();
        }

        [Test]
        public void When2dArray_UsingFindMines_ResultReturns2dArrayWithMines()
        {
            // arrange
            string[,] expected = {{ "*", "*", "1", "0", "0"},
                                  { "3", "3", "2", "0", "0"},
                                  { "1", "*", "1", "0", "0"}
                                 };


            const int row = 3;
            const int column = 5;

            string[,] input = {{ "*", "*", ".", ".", "." },
                                { ".", ".", ".", ".", "."},
                                { ".", "*", ".", ".", "."}
                               };

            // act 
            var results = _mineSweeper.GameResults(input, row, column);

            // assert
            Assert.AreEqual(expected, results);
        }


        [Test]
        public void When4X4Array_UsingFindMines_ResultReturns2dArrayWithMines()
        {
            // arrange
            string[,] expected = {{ "*", "1", "0", "0"},
                                  { "2", "2", "1", "0"},
                                  { "1", "*", "1", "0"},
                                  { "1", "1", "1", "0"}
                                 };


            const int row = 4;
            const int column = 4;

            string[,] input = {{ "*", ".", ".", "." },
                                { ".", ".", ".", "."},
                                { ".", "*", ".", "."},
                                { ".", ".", ".", "."}
                               };

            // act 
            var results = _mineSweeper.GameResults(input, row, column);

            // assert
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void When4X5Array_UsingFindMines_ResultReturns2dArrayWithMines()
        {
            // arrange
            string[,] expected = {{ "*", "1", "0", "1","*"},
                                  { "1", "2", "1", "2", "1"},
                                  { "1", "2", "*", "2", "1"},
                                  { "1", "*", "3", "*", "1"}
                                 };


            const int row = 4;
            const int column = 5;

            string[,] input = {{ "*", ".", ".", ".", "*"},
                                { ".", ".", ".", ".", "."},
                                { ".", ".", "*", ".", "."},
                                { ".", "*", ".", "*", "."}
                               };

            // act 
            var results = _mineSweeper.GameResults(input, row, column);

            // assert
            Assert.AreEqual(expected, results);
        }
    }
}