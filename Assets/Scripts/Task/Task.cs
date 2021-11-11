using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task : MonoBehaviour
{
    [SerializeField] private CardDetector _cardDetector;
    [SerializeField] private Deck _deck;
    [SerializeField] EventManager _eventManager;

    private Card _rightCard;
    public Card RightCard => _rightCard;

    private Card _choosenCard;
    private int _rightCardId;
    private int _minCardId = 0;
    private int _maxCardId => _deck.CardCount()-1;


    private void Start()
    {
        _eventManager.Subcribe(ChooseCard);
    }
    public void CardAssign()
    {
        _rightCardId = Random.Range(_minCardId, _maxCardId);
        _rightCard = _deck.RandomDeck[_rightCardId];
    }

    private bool IsRight()
    {
        return _choosenCard == _rightCard ;
    }

    public void ChooseCard()
    {
        if (_cardDetector.DetectedCard() != null)
        {
            _choosenCard = _cardDetector.DetectedCard();
            Debug.Log(_choosenCard.Description);
            if (IsRight()) Complete();
            else Fail();
        }
    }
    public void Complete()
    {
        Debug.Log("Win");
    }

    public void Fail()
    {
        Debug.Log("Fail");
    }

}
