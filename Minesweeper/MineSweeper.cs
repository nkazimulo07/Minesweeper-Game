namespace Minesweeper
{
    public class MineSweeper
    {
        private CountMines _countMines;

        public MineSweeper()
        {
            _countMines = new CountMines();
        }
        public string[,] GameResults(string[,] grid)
        {
            var safeSquare = ".";
            var numberOfMines = "";

            for (var row = 0; row < grid.GetLength(0); row++)
            {
                for (var column = 0; column < grid.GetLength(1); column++)
                {
                    if (grid[row, column] == safeSquare)
                    {
                        numberOfMines  = _countMines.FindMines(grid, row, column).ToString();
                        grid[row, column] = numberOfMines;
                    }
                }

            }

            return grid;
        }
    }
}