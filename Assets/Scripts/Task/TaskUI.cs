using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TaskUI : MonoBehaviour
{
    [SerializeField] private Text _question;

    
    public void AssignQuestion(string cardDescription)
    {
        _question.text = "Where is " + cardDescription +"?";
    }
}
