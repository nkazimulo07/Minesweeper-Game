using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    public class CountMines
    {
        public int FindMines(string[,] mine, int row, int column, int i, int j, int count)
        {
            for (int x = Math.Max(0, i - 1); x <= Math.Min(i + 1, row); x++)
            {
                for (int y = Math.Max(0, j - 1); y <= Math.Min(j + 1, column); y++)
                {
                    if (x >= 0 && y >= 0 && x < row && y < column)
                    {
                        if (x != i || y != j)
                        {
                            if (mine[x, y] == "*")
                            {
                                count++;
                            }
                        }
                    }
                }
            }

            return count;
        }
    }
}
