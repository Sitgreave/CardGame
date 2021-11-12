using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(GridLayoutGroup))]
public class CellCreator : MonoBehaviour
{
    [SerializeField] private Transform _gridLayoutTransform;
    [SerializeField] private Cell _cell;

    private List<Cell> _cells = new List<Cell>();
    public List<Cell> Cells => _cells;
    public void Create(int cellCount)
    {
        if (cellCount > 0)
        {
            
            for (int i = 0; i < cellCount; i++)
            {
                Cell cell = Instantiate(_cell, _gridLayoutTransform);
                _cells.Add(cell);
            }
        }
    }
    public void Create()
    {
                Cell cell = Instantiate(_cell, _gridLayoutTransform);
                _cells.Add(cell);
    }
}




