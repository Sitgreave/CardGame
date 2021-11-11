
using UnityEngine;

public class GameInitializer : MonoBehaviour
{
    [SerializeField] private Level _levelTemplate;
    [SerializeField] private LevelBundleData _bundleData;

    [SerializeField] private Deck _deck;
    [SerializeField] private  CardDealer _cardDealer;

    [SerializeField] private Task _task;
    [SerializeField] private TaskUI _taskUI;

    private void Start()
    {
        LevelInitialize();
        DeckInitialize();
        CardsInitialize();
        TaskInitialize();
    }
    private  void LevelInitialize()
    {
        _levelTemplate.Initialize(_bundleData.LevelData[_levelTemplate.CurrentLevel]);
    }

    private void DeckInitialize()
    {
        _deck.RandomizeDeck();
    }

    private void CardsInitialize()
    {
        _cardDealer.Deal();
    }

    private void TaskInitialize()
    {
        _task.CardAssign();
        _taskUI.AssignQuestion(_task.RightCard.Description);
 
    }

}
