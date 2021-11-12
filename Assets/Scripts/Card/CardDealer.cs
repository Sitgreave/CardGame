
using System.Collections.Generic;
using UnityEngine;

public class CardDealer : MonoBehaviour
{

    [SerializeField] private Card _cardTemplate;
    [SerializeField] private Deck _deck;
    [SerializeField] private CellCreator _cellCreator;
   
    public void Deal()
    {
        _cardTemplate.gameObject.SetActive(true);
        if (_cellCreator.Cells.Count < _deck.CardCount)
        {
            _cellCreator.Create(_deck.CardCount - _cellCreator.Cells.Count)  ;
        }   
        if (_deck.RandomDeck.Count > 0) ClearDeck();
       
        CreateDeck();
        _cardTemplate.gameObject.SetActive(false);
    }
    private void CreateDeck()
    {

            for (int i = 0; i < _deck.CardCount; i++)
            {
                Card card = Instantiate(_cardTemplate, _cellCreator.Cells[i].CardSlotTransform);
                _deck.InitializeCard(i, card);
                _deck.RandomDeck.Add(card);
            }
    }

    public void ClearDeck()
    {
        
        for (int i = 0; i < _deck.RandomDeck.Count; i++)
        {
           
            Destroy(_deck.RandomDeck[i].gameObject);
        }
        _deck.RandomDeck.Clear();
    }
 }



