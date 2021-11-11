using UnityEngine;

public class Level : MonoBehaviour
{
    private int _cardCount;
    public int CardCount => _cardCount;
    private CardType[] _cardTypeVariants;
    private CardType _currentType;
    public CardType CurrentType => _currentType;
    private int _currentLevel = 0;
    public int CurrentLevel => _currentLevel;
    
    public void Initialize(LevelData levelData)
    {
        _cardCount = levelData.CardCount;
        _cardTypeVariants = levelData.CurrentType;
        _currentType = (CardType)TypeChoise();
       
    }
    public enum CardType
    {
        letters = 0,
        numbers = 1
    }

    private int TypeChoise()
    {
        int minTypeId = 0;
        int maxTypeId = _cardTypeVariants.Length;
        if (_cardTypeVariants.Length == 1) return minTypeId;
        else return Random.Range(minTypeId, maxTypeId);
    }
    
    public void LevlUp()
    {

        _currentLevel++;
    }

    
}
