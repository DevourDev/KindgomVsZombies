using UnityEngine;

namespace Game.Core
{
    public sealed class Grid
    {
        private readonly Cell[] _cells;
        private readonly Vector2Int _size;


        public Grid(Vector2Int size)
        {
            var cells = new Cell[size.x * size.y];

            for (int i = 0, y = 0; y < size.y; y++)
            {
                for (int x = 0; x < size.x; x++)
                {
                    cells[i++] = new Cell(this, new Vector2Int(x, y));
                }
            }

            _cells = cells;
            _size = size;
        }


        public Vector2Int GetCoordsFromIndex(int index)
        {
            Vector2Int coords = new();
            coords.x = index % _size.y;
            coords.y = (index - coords.x) / _size.y;
            return coords;
        }

        public int GetIndexFromCoords(int x, int y)
        {
            return y * _size.y + x;
        }

        public int GetIndexFromCoords(Vector2Int coords)
        {
            return coords.y * _size.y + coords.x;
        }

        public Cell GetCell(int index)
        {
            return _cells[index];
        }

        public Cell GetCell(Vector2Int coords)
        {
            return GetCell(GetIndexFromCoords(coords));
        }

        public Cell GetCell(int x, int y)
        {
            return GetCell(GetIndexFromCoords(x, y));
        }
    }

    public sealed class Cell
    {
        private readonly Grid _parent;
        private readonly Vector2Int _coords;


        internal Cell(Grid grid, Vector2Int coords)
        {
            _parent = grid;
            _coords = coords;
        }


        public Vector2Int Coords => _coords;

        internal Grid ParentGrid => _parent;
    }
}
