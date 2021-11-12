
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{

    [SerializeField] private CardBundleData[] _cardBundleData;
    [SerializeField] private Level _level;
    public int CardCount => _level.CardCount;
    private Dictionary<int, int> _usedID = new Dictionary<int, int>();
    private List<Card> _randomDeck = new List<Card>();
    public List<Card> RandomDeck => _randomDeck;
    private DeckType[] _deckTypeVariants;
    private DeckType _currentDeckType;

    private void Start()
    {
       // Destroy(_cardTemplate.gameObject, .1f);
    }
   
    
    public void RandomizeDeck()
    {
        int i = 0;
        int currentRandomId;
        _deckTypeVariants = _level.GetDeckTypes(_level.CurrentLevel);
        _currentDeckType = _deckTypeVariants[TypeChoise()];
        _usedID.Clear();
        while (i < _level.CardCount)
        {

            currentRandomId = Random.Range(0, _cardBundleData[(int)_currentDeckType].CardData.Length - 1);
            if (!_usedID.ContainsValue(currentRandomId))
            {
                _usedID.Add(i, currentRandomId);
                i++;
            }
        }
    }
    private int TypeChoise()
    {
        int minTypeId = 0;
        int maxTypeId = _deckTypeVariants.Length;
        if (_deckTypeVariants.Length == 1) return minTypeId;
        else return Random.Range(minTypeId, maxTypeId);
    }
    public void InitializeCard(int cardDataId, Card card)
    {
        card.Initialize(_cardBundleData[((int)_currentDeckType)].CardData[_usedID[cardDataId]]);
    }

}

public enum DeckType
{
    letters = 0,
    numbers = 1
}