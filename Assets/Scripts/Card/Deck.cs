using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{
    [SerializeField] private Card _cardTemplate;
    public Card CardTemplate => _cardTemplate;
    [SerializeField] private CardBundleData[] _cardBundleData;
    [SerializeField] private Level _level;
    private Dictionary<int, int> _usedID = new Dictionary<int, int>();
    private List<Card> _randomDeck = new List<Card>();
    public List<Card> RandomDeck => _randomDeck;


    public int CardCount()
    {
        return _level.CardCount;
    }
    
    
    public void RandomizeDeck()
    {
        int i = 0;
        int currentRandomId;

        while (i < _level.CardCount)
        {

            currentRandomId = Random.Range(0, _cardBundleData[(int)_level.CurrentType].CardData.Length - 1);
            if (!_usedID.ContainsKey(currentRandomId))
            {
                _usedID.Add(i, currentRandomId);
                i++;
            }
        }
    }

    public void InitializeCard(int cardDataId, Card card)
    {
        card.Initialize(_cardBundleData[((int)_level.CurrentType)].CardData[_usedID[cardDataId]]);
    }
}
