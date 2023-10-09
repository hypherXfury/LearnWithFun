using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Class2_2 : MonoBehaviour
{
    public bool hasCorrectAns = false;
   public GameObject Door_Open, Door_Closed, Question;
    private void Awake() {
        Door_Closed.SetActive(true);
        Door_Open.SetActive(false);
        Question.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "switch_off" && !hasCorrectAns)
        {
            Question.SetActive(true);
        }
    }
    public void GetAnswer(string ans)
    {
        if(ans.Equals("2"))
        {
            Door_Open.SetActive(true);
            Door_Closed.SetActive(false);
            Question.SetActive(false);
            hasCorrectAns = true;
        }
    }
}
