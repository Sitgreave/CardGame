using DG.Tweening;
using System.Collections;
using UnityEngine;

public class DOTEffects : MonoBehaviour
{

    [SerializeField] private CardDetector _cardDetector;


    public void EaseInBounce_Card(float time)
    {
        if (_cardDetector.CardObject.transform != null)
        {
            _cardDetector.SelectedCard.transform.DOShakePosition(time, strength: new Vector3(0.5f, 0, 0.5f), vibrato:5, randomness: 1, snapping: false, fadeOut: true);
        }
    }

    public void Bounce_Card(float time)
    {
            if (_cardDetector.CardObject.transform != null)
            {
                _cardDetector.CardObject.transform.DOShakePosition(time, strength: new Vector3(0, .5f, 0f), vibrato: 5, randomness: 1, snapping: false, fadeOut: true);
            }
    }
    public void Bounce(Transform transform)
    {
        if (transform != null)
        {
            _cardDetector.CardObject.transform.DOShakePosition(2, strength: new Vector3(0, .5f, 0f), vibrato: 3, randomness: 1, snapping: false, fadeOut: true);
        }
    }
    

    public void EaseInBounce(Transform transform) 
    {
        if (transform != null)
        {
            _cardDetector.SelectedCard.transform.DOShakePosition(2, strength: new Vector3(0.5f, 0, 0.5f), vibrato: 3, randomness: 1, snapping: false, fadeOut: true);
        }
    }

    public void CanvasFade(CanvasGroup canvasGroup)
    {
        StartCoroutine(DoFade(canvasGroup));
    }
    private IEnumerator DoFade(CanvasGroup canvasGroup)
    {
        float counter = 0f;
        while (counter < 3)
        {
            counter += Time.deltaTime;
            canvasGroup.alpha = Mathf.Lerp(.3f, .7f, counter / 3);
            yield return null;
        }
    }
    public IEnumerator DoFade(float Duration, CanvasGroup CanvasGroup, float start, float end)
    {
        float counter = 0f;
        while (counter < Duration)
        {
            counter += Time.deltaTime;
            CanvasGroup.alpha = Mathf.Lerp(start, end, counter / Duration);
            yield return null;
        }
    }


}
