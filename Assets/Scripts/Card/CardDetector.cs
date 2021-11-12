using UnityEngine;

public class CardDetector : MonoBehaviour
{
    private GameObject _detectedObject;
    private GameObject _cardObject;
    public GameObject CardObject => _cardObject;
    private Card _selectedCard;
    public Card SelectedCard => _selectedCard;

    private void DetectObject()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit2D hit2D = Physics2D.GetRayIntersection(ray);
        if (hit2D.collider != null) _detectedObject = hit2D.collider.gameObject;
    }


    public void DetectedCard()
    {
        DetectObject();
        if (_detectedObject.GetComponent<Card>())
        {
            _selectedCard = _detectedObject.GetComponent<Card>();
            _cardObject = _detectedObject;
        }
    }
}
