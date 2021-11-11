using UnityEngine;

[System.Serializable]

public class LevelData 
{
  [SerializeField]  private int _cardCount;
    public int CardCount => _cardCount;

    [SerializeField] private Level.CardType []_cardTypeVariants;
    public Level.CardType []CurrentType => _cardTypeVariants;
}
