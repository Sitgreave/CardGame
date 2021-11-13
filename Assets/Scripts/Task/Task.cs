
using System.Collections.Generic;
using UnityEngine;

public class Task : MonoBehaviour
{
    [SerializeField] private CardDetector _cardDetector;
    [SerializeField] private Deck _deck;
    [SerializeField] private DOTEffects _effects;
    [SerializeField] LevelSwitcher _levelSwitcher;
    private Card _rightCard;
    public Card RightCard => _rightCard;

    private Card _choosenCard;
    private int _rightCardId;
    private int _minCardId = 0;
    private int _maxCardId => _deck.CardCount-1;
    [SerializeField] private EventManager _eventManager;
    private Dictionary<string, Card> _usedCards = new Dictionary<string, Card>();

    public void CardAssign()
    {
        while (true)
        {
            _rightCardId = Random.Range(_minCardId, _maxCardId);
            if (!_usedCards.ContainsKey(_deck.RandomDeck[_rightCardId].Description))
            {
                _rightCard = _deck.RandomDeck[_rightCardId];
                _usedCards.Add(_rightCard.Description, _rightCard);
                break;
            }
            
        }
    }

    private bool IsRight(Card card)
    {
        return card == _rightCard ;
    }


    public void ChooseCard()
    {
        EventType eventType;
        if (_cardDetector.SelectedCard != null)
        {
            if (IsRight(_cardDetector.SelectedCard))
            {
                eventType = EventType.RightAnswer;
                Invoke(nameof(RightAnswer), 1.2f);
            }
            else
            {
                eventType = EventType.WrongAnswer;
            }
            _eventManager.EventTrigger(eventType);

        }
    }

    private void RightAnswer()
    {
        if (!_levelSwitcher.IsLastLevel)
        {
            _levelSwitcher.NextLevel();
            _eventManager.EventTrigger(EventType.LevelSwitch);
        }
        else _eventManager.EventTrigger(EventType.EndGame);
    }


}
