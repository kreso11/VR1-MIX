using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreScript : MonoBehaviour
{

    private int score = 0;

    [SerializeField] TextMeshPro scoreshown;

    // Update is called once per frame

    void Start(){
        score = PlayerPrefs.GetInt("Player Score");
    }

    void Update()
    {
        PlayerPrefs.SetInt("Player Score", score);
        scoreshown.SetText("Score: " + score.ToString());
    }

    //called from vr logic
    public void changeScore(bool win){
        if(win){
            score++;
        }
        else{
            score--;
        }
    }
    
}
