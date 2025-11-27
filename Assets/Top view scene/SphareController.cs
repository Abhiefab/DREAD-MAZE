using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SphareController : MonoBehaviour
{
    private void Start()
    {
        Time.timeScale = 1.0f;
        
    }
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("floor"))
        {
           SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        }
    }
}
