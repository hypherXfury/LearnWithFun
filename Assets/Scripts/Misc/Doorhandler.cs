using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Doorhandler : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Class1_Door")
        {
            if(SceneManager.GetActiveScene().name.Equals("Class1_5"))
            {
                SceneManager.LoadScene("EndMenu");
            }
            else
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
        if(other.tag == "Class2_Door")
        {
            if(SceneManager.GetActiveScene().name.Equals("Class2_5"))
            {
                SceneManager.LoadScene("EndMenu");
            }
            else
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
        if(other.tag == "Class3_Door")
        {
            if(SceneManager.GetActiveScene().name.Equals("Class3_5"))
            {
                SceneManager.LoadScene("EndMenu");
            }
            else
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
    }
}
