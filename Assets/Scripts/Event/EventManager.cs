using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class EventManager : MonoBehaviour
{
    [SerializeField] private Event [] _unityEvents;
    private Dictionary<EventType, UnityEvent> _events = new Dictionary<EventType, UnityEvent>();

    private void Awake()
    {
        for (int i = 0; i < _unityEvents.Length; i++)
        {
            _events.Add(_unityEvents[i].EventType, _unityEvents[i].UnityEvent);
        }
    }
   
    public void EventTrigger(EventType type)
    {
        if(_events[type] != null)
        _events[type].Invoke();
    }

    public void UnsubscribeAll(EventType eventType)
    {
        _events[eventType] = null;
    }


}

public enum EventType
{
    Click,
    RightAnswer,
    WrongAnswer,
    LevelSwitch,
    EndGame,
    Restart
}
