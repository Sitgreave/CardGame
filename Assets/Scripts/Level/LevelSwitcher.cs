using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSwitcher : MonoBehaviour
{
   [SerializeField] private Level _level;
    [SerializeField] private EventManager _eventManager;
    private int _currentRepeat = 0;
   
    public void NextLevel()
    {
        if (_currentRepeat < _level.RepeatCount)
        {
            _currentRepeat++;
        }
        else if (_level.CurrentLevel < _level.LevelsCount - 1)
        {
            _level.Up();
            _currentRepeat = 0;
        }
        else if (_level.CurrentLevel == _level.LevelsCount - 1)
        {
            _eventManager.EventTrigger(EventType.EndGame);
            _eventManager.UnsubscribeAll(EventType.Click);
        }
   
    }

    

    
}
