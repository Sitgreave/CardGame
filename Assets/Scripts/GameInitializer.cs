
using UnityEngine;

public class GameInitializer : MonoBehaviour
{
    [SerializeField] private Level _levelTemplate;
    [SerializeField] private LevelBundleData _bundleData;

    [SerializeField] private Deck _deck;
    [SerializeField] private  CardDealer _cardDealer;

    [SerializeField] private Task _task;
    [SerializeField] private TaskUI _taskUI;

    [SerializeField] private EventManager _eventManager;


    private void Start()
    {
        Initialize();
    }


    public void Initialize()
    {
        LevelInitialize();
            DeckInitialize();
            CardsInitialize();
            TaskInitialize();
    }
    public void Initialize(float time)
    {
        Invoke(nameof(Initialize), time);
    }
    private  void LevelInitialize()
    {
        try
        {
            _levelTemplate.Initialize(_bundleData.LevelData[_levelTemplate.CurrentLevel]);
        }
        catch
        {
            Debug.Log("Level initialize error");
        }
    }

    private void DeckInitialize()
    {
        try
        {
            _deck.RandomizeDeck();
        }
        catch
        {
            Debug.Log("Deck initialize error");
        }
    }

    private void CardsInitialize()
    {
        try
        {
            _cardDealer.Deal();
        }
        catch
        {
            Debug.Log("Cards initialize error");
        }
    }

    private void TaskInitialize()
    {
        try
        {
            _task.CardAssign();
            _taskUI.AssignQuestion(_task.RightCard.Description);
        }
         catch
        {
            Debug.Log("Level initialize error");
        }

    }

}
