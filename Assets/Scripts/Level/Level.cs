using UnityEngine;

public class Level : MonoBehaviour
{
    [SerializeField] private LevelBundleData _bundleData;
    private int _cardCount;
    public int CardCount => _cardCount;
    private int _currentLevel = 0;
    public int CurrentLevel => _currentLevel;
    private int _repeatCount;
    public int RepeatCount => _repeatCount;

    public DeckType[] GetDeckTypes(int i)
    {
        return _bundleData.LevelData[i].DeckTypeVariants;
    }
      
    public int LevelsCount => _bundleData.LevelData.Length;
    
    public void Initialize(LevelData levelData)
    {
        _cardCount = levelData.CardCount;
       
        _repeatCount = levelData.RepeatCount;
       
    }
    

  
    
    public void Up()
    {
        _currentLevel++;
    }
    public void Reset()
    {
        _currentLevel = 0;
    }

}
