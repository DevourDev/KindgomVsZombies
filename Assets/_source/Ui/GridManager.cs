using Game.Core;
using System;
using System.Drawing;
using UnityEngine;
#if UNITY_EDITOR
#endif

namespace Game.Assets.Ui
{


    public sealed class GridManager : MonoBehaviour
    {
        [SerializeField] private CellOnScene _cellPrefab;
        [SerializeField] private float _cellSize = 2f;
        [SerializeField] private int _sizeX;
        [SerializeField] private int _sizeY;

        private static GridManager _inst;

        private Core.Grid _internalGrid;
        private CellOnScene[] _cellsOnScene;


        private void Awake()
        {
            _inst = this;
            _internalGrid = new(new Vector2Int(_sizeX, _sizeY));
        }

        private void Start()
        {
            _cellsOnScene = new CellOnScene[_sizeX * _sizeY];

            for (int i = 0, y = 0; y < _sizeY; y++)
            {
                for (int x = 0; x < _sizeX; x++)
                {
                    var cell = Instantiate(_cellPrefab, GetWorldPosition(x, y), Quaternion.identity);
                    _cellsOnScene[i++] = cell;
                    cell.Init(this, _internalGrid.GetCell(new Vector2Int(x, y)));
                }
            }
        }



        private void OnDestroy()
        {
            if (_inst == this)
                _inst = null;
        }


        private Vector3 GetWorldPosition(int x, int y)
        {
            return new Vector3(x * _cellSize, y * _cellSize);
        }


    }
}
