using UnityEngine;
public class LevelSwitcher : MonoBehaviour
{
   [SerializeField] private Level _level;
    private int _currentRepeat = 1;
    private bool _isLastLevel;
    public bool IsLastLevel => _isLastLevel;
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

        if (_currentRepeat == _level.RepeatCount  && _level.CurrentLevel == _level.LevelsCount - 1) _isLastLevel = true;

    } 

    
}
