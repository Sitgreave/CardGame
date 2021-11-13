using DG.Tweening;
using UnityEngine;

public class DOTEffects : MonoBehaviour
{
    
    [SerializeField] private CardDetector _cardDetector;
    private Tween _fadeTween;
    [SerializeField] private Vector3 _strengthBounce;
    [SerializeField] private Vector3 _strengthEaseBounce;
    private const float _bounceTime = 1f;
    private const float _fadeTime = 3f;
    public void EaseInBounce_Card()
    {
        Bounce(_strengthEaseBounce);
    }

    public void Bounce_Card()
    {
        Bounce(_strengthBounce);
    }

    private void Bounce(Vector3 strength)
    {
        if (_cardDetector.CardObject.transform != null)
        {
            _cardDetector.CardObject.transform.DOShakePosition(_bounceTime, strength: strength, vibrato: 5, randomness: 1, snapping: false, fadeOut: true);
        }
    }


    public void FadeOut(CanvasGroup canvas)
    {
        canvas.alpha = 0.8f;
        Fade(canvas, 0);
    }
    public void FaidIn(CanvasGroup canvas)
    {
        canvas.alpha = 0.3f;
        Fade(canvas, 1);
    }

    private void Fade(CanvasGroup canvas, float alphaValue)
    {
        _fadeTween?.Kill();
        _fadeTween = canvas.DOFade(alphaValue, _fadeTime);
    }



   


}
