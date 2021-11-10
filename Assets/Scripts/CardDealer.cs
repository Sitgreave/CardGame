using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDealer : MonoBehaviour
{
    [SerializeField] private List<Card> cards;
    [SerializeField] private int _cardCount;
    [SerializeField] private CellCreator _cellCreator;
    private readonly List<Card> _randomDeck;


    private void Start()
    {
        Shuffle();
        Deal();
    }
    public void Shuffle()
    {
        int i = 0;
        int currentRandomId;
        _randomDeck.Clear();
        Dictionary <int, int>  usedID = null;


        while ( i < _cardCount)
        {
            
           currentRandomId = GetRandomCardId();
            if (!usedID.ContainsKey(currentRandomId))
            {
                _randomDeck.Add(cards[currentRandomId]);
                usedID.Add(currentRandomId, i);
                i++;
            }            
        }
    }

    public void Deal()
    {

        _cellCreator.Create(_cardCount);
        for (int i = 0; i < _cardCount; i++)
        {
            Instantiate(_randomDeck[i], _cellCreator.Cells[i].CardSlotTransorm);
        }
    }

    private int GetRandomCardId()
    {
        int randomId = Random.Range(0, cards.Capacity - 1);
        return randomId;
    }
}
