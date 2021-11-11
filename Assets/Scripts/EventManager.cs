using UnityEngine;
using UnityEngine.Events;

public class EventManager : MonoBehaviour
{

    [SerializeField] private UnityEvent _event;
    public UnityEvent unityEvent => _event;
    public void Subcribe(UnityAction unityAction)
    {
        _event.AddListener(unityAction);
    }

    public void Unsubcribe(UnityAction unityAction)
    {
        _event.RemoveListener(unityAction);
    }
}
