using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadScreen : MonoBehaviour
{
    [SerializeField] private GameObject _loadingScreen;
    [SerializeField] private int _loadLevel;
    [SerializeField] private Slider _bar;
    [SerializeField] private Text _text;
   
    public void Load()
    {
        _loadingScreen.SetActive(true);
      //  SceneManager.LoadScene(_loadLevel);
       
        StartCoroutine(LoadAsync());
    }

    private IEnumerator LoadAsync()
    {
        AsyncOperation async = SceneManager.LoadSceneAsync(_loadLevel);
        async.allowSceneActivation = false;
        while (!async.isDone)
        {
            _bar.value = async.progress;

            if (async.progress ==.99f && !async.allowSceneActivation)
            {
                _text.text = "Press any key to continue";
                if (Input.anyKey)
                {
                    async.allowSceneActivation = true;
                }
            }
            yield return null;
        }
    }
}
