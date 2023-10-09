using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Class2_4 : MonoBehaviour
{
    public GameObject Door_Open, Door_Closed, Question;
    public bool hasCorrectAns = false;
    private void Awake() {
        Door_Closed.SetActive(true);
        Door_Open.SetActive(false);
        Question.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "switch_off")
        {
            Question.SetActive(true);
        }
    }
    public void GetAnswer(string ans)
    {
        if(ans.Equals("7"))
        {
            Door_Open.SetActive(true);
            Door_Closed.SetActive(false);
            Question.SetActive(false);
            hasCorrectAns = true;
        }
    }
}
