using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(SpriteRenderer))]

public class Card : MonoBehaviour
{
    private Sprite _sprite;
    private string _description;

    public string Description => _description;
    private SpriteRenderer _spriteRenderer;
    [SerializeField] private EventManager _eventManager;

    
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
        if(_eventManager != null)
        _eventManager.unityEvent.Invoke();
    }
    
    


}
