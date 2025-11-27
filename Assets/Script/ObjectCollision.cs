using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCollision : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "player") {

            Debug.Log("I have Collide");


        }
        else
        {
            Debug.Log("I havn't collide yet");
        }
    }

    
}
