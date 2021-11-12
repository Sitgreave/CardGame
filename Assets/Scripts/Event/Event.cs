using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class Event
{
    [SerializeField] private string Name;
    [SerializeField] private EventType _eventType;
    public EventType EventType => _eventType;
    [SerializeField]  private UnityEvent _unityEvent;
    public UnityEvent UnityEvent => _unityEvent;


    
}
