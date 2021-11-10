using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    //private Transform _cardSlotTransform;
    private Sprite _sprite;
    private string _description;

    public string Description => _description;
    SpriteRenderer spriteRenderer;
   private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    public void Initialize(CardData cardData)
    {
        _description = cardData.Description;
        _sprite = cardData.Sprite;
        spriteRenderer.sprite = _sprite;
    }
}
