using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDealer : MonoBehaviour
{
    [SerializeField] private List<Card> cards;
    [SerializeField] private int _cardCount;
    [SerializeField] private CellCreator _cellCreator;
    private List<Card> _randomDeck = new List<Card>();
    Dictionary<int, int> usedID = new Dictionary<int, int>();
    private void Start()
    {
        
        Shuffle();
        Deal();
    }
    public void Shuffle()
    {
       
    
        int i = 0;
        int currentRandomId;
        // _randomDeck.Clear();
        int j = 0;


        while ( i < _cardCount)
        {
            
           currentRandomId = GetRandomCardId();
            if (!usedID.ContainsKey(currentRandomId))
            {
                _randomDeck.Add(cards[currentRandomId]);
                usedID.Add(currentRandomId, i);
                i++;
            }
            j++;
            if (j > 100) break;
        }
    }

    public void Deal()
    {

        _cellCreator.Create(_cardCount);
        for (int i = 0; i < _cardCount; i++)
        {
            Instantiate(_randomDeck[i]);
            Card card = Instantiate(_randomDeck[i], _cellCreator.Cells[i].CardSlotTransform) as Card;
            
        }
    }

    private int GetRandomCardId()
    {
        int randomId = Random.Range(0, cards.Capacity - 1);
        return randomId;
    }
}
