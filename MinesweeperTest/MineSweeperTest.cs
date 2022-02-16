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
        public void When3x5Grid_UsingFindMines_ResultReturnsGridyWithMines()
        {
            // arrange
            string[,] input = {{ "*", "*", ".", ".", "." },
                                { ".", ".", ".", ".", "."},
                                { ".", "*", ".", ".", "."}
                               };

            string[,] expected = {{ "*", "*", "1", "0", "0"},
                                  { "3", "3", "2", "0", "0"},
                                  { "1", "*", "1", "0", "0"}
                                 };

            // act 
            var results = _mineSweeper.GameResults(input);

            // assert
            Assert.AreEqual(expected, results);
        }


        [Test]
        public void When4X4Grid_UsingFindMines_ResultReturnsGridWithMines()
        {
            // arrange
            string[,] input = {{ "*", ".", ".", "." },
                                { ".", ".", ".", "."},
                                { ".", "*", ".", "."},
                                { ".", ".", ".", "."}
                               };

            string[,] expected = {{ "*", "1", "0", "0"},
                                  { "2", "2", "1", "0"},
                                  { "1", "*", "1", "0"},
                                  { "1", "1", "1", "0"}
                                 };

            // act 
            var results = _mineSweeper.GameResults(input);

            // assert
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void When4X5Grid_UsingFindMines_ResultReturnsGridWithMines()
        {
            // arrange
            string[,] input = {{ "*", ".", ".", ".", "*"},
                                { ".", ".", ".", ".", "."},
                                { ".", ".", "*", ".", "."},
                                { ".", "*", ".", "*", "."}
                               };

            string[,] expected = {{ "*", "1", "0", "1","*"},
                                  { "1", "2", "1", "2", "1"},
                                  { "1", "2", "*", "2", "1"},
                                  { "1", "*", "3", "*", "1"}
                                 };


            // act 
            var results = _mineSweeper.GameResults(input);

            // assert
            Assert.AreEqual(expected, results);
        }
    }
}