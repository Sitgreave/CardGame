using UnityEngine;
using UnityEngine.SceneManagement;

public class UserInterface : MonoBehaviour
{
    [SerializeField] private GameObject _panel;
    [SerializeField] private UserButton[] _buttons; 

    public void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
    // public void 
}
