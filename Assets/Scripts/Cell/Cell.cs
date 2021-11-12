using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(LayoutElement))]
public class Cell : MonoBehaviour
{
  [SerializeField]  private Transform _cardSlotTransform;
    public Transform CardSlotTransform => _cardSlotTransform;
    private void Start()
    {
        Invoke( nameof(Bounce), .01f);
    }

    private void Bounce()
    {
        transform.DOShakePosition(1.5f, strength: new Vector3(0, .5f, 0f), vibrato: 3, randomness: 1, snapping: false, fadeOut: true);
    }
}
