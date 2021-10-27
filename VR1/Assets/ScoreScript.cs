using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreScript : MonoBehaviour
{

    private int score = 0;

    [SerializeField] TextMeshPro scoreshown;

    // Update is called once per frame
    void Update()
    {
        scoreshown.SetText("Score: " + score.ToString());
    }

    //called from vr logic
    //prviate void changeScore(win){
    //    if(win){
    //        score++;
    //    }
    //    else{
    //        score--;
    //    }
    //}
    //
}
