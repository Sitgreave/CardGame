using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDealer : MonoBehaviour
{
  

    [SerializeField] private Card _cardTemplate;
    [SerializeField] private int _cardCount;
    [SerializeField] private CellCreator _cellCreator;
    private List<Card> _randomDeck = new List<Card>();
    Dictionary<int, int> usedID = new Dictionary<int, int>();

    [SerializeField] private CardBundleData[] _cardBundleData;
    private void Start()
    {
        //Debug.Log(card.Description);
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
                usedID.Add(i, currentRandomId );
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
            Card randomCard = Instantiate(_cardTemplate, _cellCreator.Cells[i].CardSlotTransform);
            randomCard.Initialize(_cardBundleData[0].CardData[usedID[i]]);
            _randomDeck.Add(randomCard);
            
        }
    }

    private int GetRandomCardId()
    {
        int randomId = Random.Range(0, _cardBundleData[0].CardData.Length - 1);
        return randomId;
    }
}
