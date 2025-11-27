using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseResume : MonoBehaviour
{

    public GameObject PauseScreen;
    

    bool GamePaused;



    // Start is called before the first frame update
    void Start()
    {
        GamePaused = false;
        Cursor.visible = false;
    }

    // Update is called once per frame
   public void Update()
    {
        if (GamePaused) {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseScreen.SetActive(true);
            Cursor.visible = true;

        }
    }
    

    public void PauseGame()
    {
        GamePaused = true;
        PauseScreen.SetActive(true);
        Cursor.visible = true;
        
    }

    public void ResumeGame()
    {
        GamePaused = false;
        PauseScreen.SetActive(false);
        Cursor.visible = false;
       
    }
    public void Restart()
    {
        SceneManager.LoadScene("Top view");
    }
    public void QuitGame()
    {
        Debug.Log("Game is quit");
        Application.Quit();
    }
}