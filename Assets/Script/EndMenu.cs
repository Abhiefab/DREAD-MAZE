using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMenu : MonoBehaviour
{
    // Start is called before the first frame update

    private void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }


    public void QuitGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene() .buildIndex -1);
    
        
    }
    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Exit button is pressed ");
       

    }

}
