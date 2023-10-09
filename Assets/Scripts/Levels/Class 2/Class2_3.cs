using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Class2_3 : MonoBehaviour
{
    public GameObject Door_Closed, Door_Open, Question;
    public bool hasCorrectAns;
    private void Start()
    {
        Door_Closed.SetActive(true);
        Door_Open.SetActive(false);
       Question.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other) {
     if (other.tag == "switch_off"&&!hasCorrectAns)
        {
            Question.SetActive(true);
        }
    }   

   public void GetAnswer(string s)
   {
    if((s.Equals("Sun"))||(s.Equals("sun")))
    {
    Door_Closed.SetActive(false);
    Door_Open.SetActive(true);
    Question.SetActive(false);
    hasCorrectAns=true;
    }
   }
}
