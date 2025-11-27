using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canvasManage1 : MonoBehaviour
{
    public GameObject PauseScreen;
    bool gamePaused;

    private void Start()
    {
        gamePaused = false;
    }
    private void Update()
    {
        if (gamePaused)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }




    public void pauseGame()
    {
       gamePaused = true;

    }
    public void ResumeGame() 
    {
        gamePaused = false;
    }
}
