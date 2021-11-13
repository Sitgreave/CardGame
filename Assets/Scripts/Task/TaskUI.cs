using UnityEngine;
using UnityEngine.UI;

public class TaskUI : MonoBehaviour
{
    [SerializeField] private Text _question;
    [SerializeField] private DOTEffects _effects;
    [SerializeField] private CanvasGroup _canvas;
    
    public void AssignQuestion(string cardDescription)
    {
        _question.text = "Where is " + cardDescription +"?";
    }

    private void Start()
    {
        TextFadeIn();
    }
    
    public void TextFadeIn()
    {
        _effects.FaidIn(_canvas);
    }
}
