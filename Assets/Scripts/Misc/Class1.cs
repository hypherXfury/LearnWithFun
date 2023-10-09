using UnityEngine.SceneManagement;
using UnityEngine;

public class Class1 : MonoBehaviour
{
   public void LoadClass1()
   {
      Time.timeScale = 1.0f;
    SceneManager.LoadScene("Class1_1");
   }
   public void LoadClass2()
   {
      Time.timeScale = 1.0f;
    SceneManager.LoadScene("Class2_1");
   }
   public void LoadClass3()
   {
      Time.timeScale = 1.0f;
    SceneManager.LoadScene("Class3_1");
   }

   public void Quit()
   {
      Application.Quit();
   }
}
