
using System.Collections.Generic;
using UnityEngine;

public class CardDealer : MonoBehaviour
{
  

    [SerializeField] private Deck _deck;
    [SerializeField] private CellCreator _cellCreator;
 

    public void Deal()
    {
        _cellCreator.Create(_deck.CardCount());
        CreateDeck();
    }
    private void CreateDeck()
    {
           _deck.RandomDeck.Clear();

            for (int i = 0; i < _deck.CardCount(); i++)
            {
                Card card = Instantiate(_deck.CardTemplate, _cellCreator.Cells[i].CardSlotTransform);
                _deck.InitializeCard(i, card);
                _deck.RandomDeck.Add(card);
            }
        }
    }



