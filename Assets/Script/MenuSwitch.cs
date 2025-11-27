using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuController : MonoBehaviour
{
  public void quitGame()
    {
        Debug.Log("Game is quit ");
        Application.Quit();
        
    }
    public void RestartGame()
    {
        Debug.Log("Game is restarted ");
        SceneManager.LoadScene("Top view");
       
       
    }
    public void ResumeGame()
    {
        // Load the previous scene if available
        int previousSceneIndex = PlayerPrefs.GetInt("PreviousSceneIndex", 0);
        SceneManager.LoadScene(previousSceneIndex);
    }
}
