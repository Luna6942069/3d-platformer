using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScreen : MonoBehaviour
{
   

    public GameObject deathScreenCanvas;
  
    public void ShowDeathScreen()
    {
        deathScreenCanvas.SetActive(true);

        Time.timeScale = 1f;

    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void QuitGame()
    {
        Time.timeScale = 1f;
        Application.Quit();
    
    }
}
