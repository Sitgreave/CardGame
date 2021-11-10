using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(GridLayoutGroup))]
public class CellCreator : MonoBehaviour
{
    [SerializeField] private Transform _gridLayoutTransform;
    private const int _cellsInRow = 3;
    public void Create(Cell cell, int cellCount)
    {
        if (cellCount % _cellsInRow == 0) // кратно ли введёное значение минимальному количеству строк (3)
        {
            for (int i = 0; i < cellCount; i++)
            {
                Instantiate(cell, _gridLayoutTransform);
            }
        }
        else Debug.Log("Incorrect cell count (not divisible by 3) ");
    }

    


}
