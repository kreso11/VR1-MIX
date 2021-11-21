using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;



public class GameScript : MonoBehaviour
{
    [SerializeField] TextMeshPro helpText;
    private float countdownStartingTime = 4;
    private float currentTime;
    
    private GestureDetectionText GDT;
    private ScoreScript ScoreSc;

    bool called = false;
    string result;


    string gesture;
    string gestureFinal;
    bool countdown = false;


    void Start() {
        currentTime = countdownStartingTime;

        GameObject GDTScript = GameObject.Find("CurrentDetection");
        GDT = (GestureDetectionText) GDTScript.GetComponent(typeof(GestureDetectionText));

        GameObject ScoreScriptS = GameObject.Find("Score");
        ScoreSc = (ScoreScript) ScoreScriptS.GetComponent(typeof(ScoreScript));
    }

    // Update is called once per frame
    void Update()
    {
        gesture = GDT.getCurrentShown();

        if (gesture == "OK"){
            countdown = true;
        }

        if (countdown){
            reduceEachSecond();
        }

        if (gesture == "Thumbs Up"){
            Debug.Log("Restarting");
            SceneManager.LoadScene("GAME");
        }
    }

    void reduceEachSecond(){
        currentTime -= 1 * Time.deltaTime;
        float seconds = Mathf.FloorToInt(currentTime % 60);
        helpText.SetText("Show in " + (seconds));

        if (currentTime <= 0){
            if (!called){
            GameObject go = GameObject.Find("Cards");
            CardTurningScript other = (CardTurningScript) go.GetComponent(typeof(CardTurningScript));
            result = other.turnCards();
            called = true;

            gestureFinal = GDT.getCurrentShown();

            if (gestureFinal == "Nothing"){
                helpText.SetText("Nothing reckon. Show thumbs up to restart!");
            }

            if (gestureFinal == result){
                helpText.SetText("Its a tie! Show thumbs up to restart!");
            }

            if (gestureFinal != result){
                if (gestureFinal == "Rock" && result == "Paper" || gestureFinal=="Paper" && result=="Sci" || gestureFinal=="Sci" && result=="Rock"){
                    helpText.SetText("You lost! Show thumbs up to restart!");
                    ScoreSc.changeScore(false);
                }
                else{
                    helpText.SetText("You won! Show thumbs up to restart!");
                    ScoreSc.changeScore(true);
                }
            }
            
            currentTime = countdownStartingTime;
            countdown=false;
            }

        }
    }


}
