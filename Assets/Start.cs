using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start : MonoBehaviour
{
    public void StartGame()
    {
        
        SceneManager.LoadScene("Level01");
        Time.timeScale = 1f;
    }
}
