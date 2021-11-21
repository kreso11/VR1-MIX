using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GestureDetectionText : MonoBehaviour
{

    [SerializeField] TextMeshPro displayGestureText;
    private string currentShown;

    public void Rock(){
        displayGestureText.SetText("Rock");
        currentShown = "Rock";
    }

    public void Sci(){
        displayGestureText.SetText("Sci");
        currentShown = "Sci";
    }

    public void Paper(){
        displayGestureText.SetText("Paper");
        currentShown = "Paper";
    }

    public void Nothing(){
        displayGestureText.SetText("Nothing");
        currentShown = "Nothing";
    }

    public void Ok(){
        displayGestureText.SetText("OK");
        currentShown = "OK";
    }

    public void ThumbsUp(){
        displayGestureText.SetText("Thumbs Up");
        currentShown = "Thumbs Up";
    }

    public string getCurrentShown(){
        return currentShown;
    }
}
