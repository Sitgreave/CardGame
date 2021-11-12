using UnityEngine;

public class ParticleAppearance : MonoBehaviour
{
    [SerializeField] private CardDetector _cardDetector;
    [SerializeField] private ParticleSystem _particle;
    public void Appear()
    {
        transform.position = _cardDetector.CardObject.transform.position;
        _particle.Play();
    }


}
