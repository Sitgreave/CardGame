using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]

public class Card : MonoBehaviour
{
    private Sprite _sprite;
    private string _description;

    public string Description => _description;
    private SpriteRenderer _spriteRenderer;

   [SerializeField] private ClickHandler _clickHandler;
   


    private void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }
    public void Initialize(CardData cardData)
    {
        _description = cardData.Description;
        _sprite = cardData.Sprite;
        _spriteRenderer.sprite = _sprite;
    }

    private void OnMouseDown()
    {
        _clickHandler.TryClick();
    }





}
