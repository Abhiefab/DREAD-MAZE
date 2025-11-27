using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WastedGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       Cursor.visible= true;
        Cursor.lockState = CursorLockMode.None;
    }

   public void Replay()
    {
        SceneManager.LoadScene("Main Game");
    }
    public void Exit()
    {
        Application.Quit();
    }

  
    
}
