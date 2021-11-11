using UnityEngine;

public class CardDetector : MonoBehaviour
{
    private GameObject _detectedObject;
    private void DetectObject()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit2D hit2D = Physics2D.GetRayIntersection(ray);
        if (hit2D.collider != null) _detectedObject = hit2D.collider.gameObject;
    }

    
    public Card DetectedCard()
    {
        DetectObject();
        if (_detectedObject.GetComponent<Card>()) return _detectedObject.GetComponent<Card>();
        else return null;
    }
}
