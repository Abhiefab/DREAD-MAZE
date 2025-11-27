using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camerafollow : MonoBehaviour
{
    [SerializeField] Transform followball;

    private void Update()
    {
        transform.position = followball.position;
    }
}
