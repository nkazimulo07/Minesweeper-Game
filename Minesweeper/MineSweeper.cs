namespace Minesweeper
{
    public class MineSweeper
    {
        private CountMines _countMines;

        public MineSweeper()
        {
            _countMines = new CountMines();
        }
        public string[,] GameResults(string[,] mine, int row, int column)
        {
            int count;

            for (var i = 0; i < row; i++)
            {
                for (var j = 0; j < column; j++)
                {
                    if (mine[i, j] == ".")
                    {
                        count = 0;
                        mine[i, j] = (_countMines.FindMines(mine, row, column, i, j, count)).ToString();
                    }
                }

            }

            return mine;
        }
    }
}