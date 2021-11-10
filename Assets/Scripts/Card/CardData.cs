using UnityEngine;

[System.Serializable]
public class CardData 
{
    [SerializeField] private string _description;
    public string Description => _description;

    [SerializeField] private Sprite _sprite;
    public Sprite Sprite => _sprite;

    //Initialize
}
