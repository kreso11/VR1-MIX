using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardTurningScript : MonoBehaviour
{
    [SerializeField] Plane Rock,Paper,Sci;
    private int totalObjects = 4;

     List<int> startList = new List<int>();
     List<int> endList = new List<int>();

    List<int> selectedList = new List<int>();

    void Start() {
        startList.Add(1);
        startList.Add(2);
        startList.Add(3);

        selectCards();
    }

    // Update is called once per frame
    void Update()
    {
    }

    List<int> selectCards(){
        if (startList.Count==3){

            endList = startList;

            int pos = Random.Range(0, endList.Count);
            int random1 = endList[pos];
            endList.RemoveAt(pos);

            int pos2 = Random.Range(0, endList.Count);
            int random2 = endList[pos2];
            endList.RemoveAt(pos2);

            selectedList.Add(random1);
            selectedList.Add(random2);

            return selectedList;
        }
        return null;
    }

    public string turnCards(){
        if (selectedList.Contains(1)){
            GameObject rock = GameObject.Find("Rock");
            rock.transform.Rotate(180, 0, 0.0f, Space.Self);
        }
        if (selectedList.Contains(2)){
            GameObject paper = GameObject.Find("Paper");
            paper.transform.Rotate(180, 0, 0.0f, Space.Self);
        }
        if (selectedList.Contains(3)){
            GameObject sci = GameObject.Find("Sci");
            sci.transform.Rotate(180, 0, 0.0f, Space.Self);
        }
        
        if (endList[0] == 1){return "Rock";}
        if (endList[0] == 2){return "Paper";}
        if (endList[0] == 3){return "Sci";}

        return "Error";
    }
}
