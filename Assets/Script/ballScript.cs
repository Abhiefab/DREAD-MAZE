using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ballScript : MonoBehaviour
{
   public  Rigidbody myrigid;
    public float MyPower;
    private Vector2 startingPosition;
    // Start is called before the first frame update
    void EndScreen()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    void Start()
    {
        startingPosition = transform.position;
        
    }

    // Update is called once per frame
  public  void Update()
    {
        void resetBall()
        {
            transform.position = startingPosition;
        }

        if (transform.position.y <= 27)
        {
            resetBall();
           EndScreen();


        }

        if (Input.GetKey(KeyCode.D))

        {
            myrigid.linearVelocity = Vector3.right * MyPower;

        }

        if (Input.GetKey(KeyCode.A))
        {
            myrigid.linearVelocity = Vector3.left * MyPower;

        }
        if (Input.GetKey(KeyCode.W))
        {
            myrigid.linearVelocity = Vector3.forward * MyPower;

        }
        if (Input.GetKey(KeyCode.S))
        {
            myrigid.linearVelocity = Vector3.back * MyPower;
        }
        if (Input.GetKeyDown(KeyCode.Space)) {
            myrigid.linearVelocity = Vector3.up * MyPower;
        }

      

      
    }
   
}
