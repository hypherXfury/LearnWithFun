using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class Class1_1 : MonoBehaviour
{
    public GameObject Door_Open, Door_Closed, Question;
    public bool hasCorrectAns = false;
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
        if(ans.Equals("capital letter", StringComparison.InvariantCultureIgnoreCase))
        {
            Door_Open.SetActive(true);
            Door_Closed.SetActive(false);
            Question.SetActive(false);
            hasCorrectAns = true;
        }
    }

}
