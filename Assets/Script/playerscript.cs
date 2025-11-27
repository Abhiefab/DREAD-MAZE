using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerscript : MonoBehaviour
{
    public  Rigidbody MyPlayer;
    public float Playerup;
    public float PlayerSprint;

   
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow)) { transform.position += Vector3.right * Time.deltaTime;
        }

        if(Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.forward * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.back * Time.deltaTime;
        }
        if(Input .GetKeyDown(KeyCode.Space)) {
            MyPlayer.linearVelocity = Vector3.up * Playerup;   
        
        }

    }
}

   
    

