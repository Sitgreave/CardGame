using UnityEngine;

[System.Serializable]

public class LevelData 
{
  [SerializeField]  private int _cardCount;
    public int CardCount => _cardCount;

    [SerializeField] private DeckType []_deckTypeVariants;
    public DeckType [] DeckTypeVariants => _deckTypeVariants;
    [SerializeField] private int _repeatCount;
    public int RepeatCount => _repeatCount;
}
