
using UnityEngine;

public class ClickHandler : MonoBehaviour
{
    [SerializeField] private float _clickInterval;
    [SerializeField] private EventManager _eventManager;
    private bool _allowClick = true;
    private bool _needHandle =  true;
    public void DisableHandler()
    {
        _needHandle = false;
    }
    public void TryClick()
    {

            if (_allowClick && _needHandle)
            {
                _eventManager.EventTrigger(EventType.Click);
                _allowClick = false;
                Invoke(nameof(WaitInterval), _clickInterval);

            }
        
    }
    private void WaitInterval()
    {
        _allowClick = true;
    }
}
