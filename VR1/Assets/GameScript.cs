using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameScript : MonoBehaviour
{
    [SerializeField] TextMeshPro helpText;
    private float countdownStartingTime = 4;
    private float currentTime;

    bool called = false;
    string result;

    void Start() {
        currentTime = countdownStartingTime;
    }

    // Update is called once per frame
    void Update()
    {
        //headset show ok  if (showok){
        //reduceEachSecond();  
        //}
        reduceEachSecond();
    }

    void reduceEachSecond(){
        currentTime -= 1 * Time.deltaTime;
        float seconds = Mathf.FloorToInt(currentTime % 60);
        helpText.SetText("Show in " + (seconds));

        if (currentTime <= 0){
            //call Card turning method and return card
            if (!called){
            GameObject go = GameObject.Find("Cards");
            CardTurningScript other = (CardTurningScript) go.GetComponent(typeof(CardTurningScript));
            result = other.turnCards();
            called = true;
            }
            //get Vr input
            //compare
            //wait for ok and restart
            helpText.SetText(result);
        }
    }


}
