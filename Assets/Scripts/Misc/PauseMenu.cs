using UnityEngine.SceneManagement;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuUI;
    public bool isResume;
   private void Start() {
    pauseMenuUI.SetActive(false);
   }
   public void Pause()
   {
        if(!isResume)
        {
            pauseMenuUI.SetActive(true);
            isResume = true;
            Time.timeScale = 0f;
        }
   }
   public void Resume()
   {
        if(isResume){
        isResume = false;
        Time.timeScale = 1f;
        pauseMenuUI.SetActive(false);
        }
   }
    public void Quit()
    {
        Application.Quit();
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
