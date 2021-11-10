using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(LayoutElement))]
public class Cell : MonoBehaviour
{
  [SerializeField]  private Transform _cardSlotTransform;

    public Transform CardSlotTransform => _cardSlotTransform;
}
