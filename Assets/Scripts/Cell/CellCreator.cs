using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(GridLayoutGroup))]
public class CellCreator : MonoBehaviour
{
    [SerializeField] private Transform _gridLayoutTransform;
    [SerializeField] Cell _cell;
    private const int _cellsInRow = 3;

    private List<Cell> _cells = new List<Cell>();
    public List<Cell> Cells => _cells;
    public void Create(int cellCount)
    {
        if (cellCount % _cellsInRow == 0) // кратно ли введёное значение минимальному количеству строк (3)
        {
            _cells.Clear();
            for (int i = 0; i < cellCount; i++)
            {
              Cell cell = Instantiate(_cell, _gridLayoutTransform);
                _cells.Add(cell);
            }
        }
        else Debug.Log("Incorrect cell count (not divisible by 3) ");
    }

    


}
