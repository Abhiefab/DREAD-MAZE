using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
public class CameraController : MonoBehaviour
{

   
    [SerializeField] Transform followTarget;
    [SerializeField] float distnace = 5;
    [SerializeField] float minVerticalAngle = -45;
    [SerializeField] float maxVerticalAngle = 45;
    [SerializeField] Vector2 framingOffset;

    float MouseY;
    float MouseX;
    float Click;

    private void Start()
    {
    
      // Cursor.lockState = CursorLockMode.Locked;

        
    }

    private void Update()
    {
       


        MouseY += Input.GetAxis("Mouse X");
        MouseX += Input.GetAxis("Mouse Y");
        MouseX = Mathf.Clamp(MouseX, minVerticalAngle, maxVerticalAngle);


        var targetRotation = Quaternion.Euler(MouseX, MouseY, 0);

        var focusPostiion = followTarget.position + new Vector3(framingOffset.x, framingOffset.y);

        transform.position = focusPostiion - targetRotation * new Vector3(0, 0, distnace);
        transform.rotation = targetRotation;
    }

    public Quaternion GetPlannerRotation()
    {
        return Quaternion.Euler(0, MouseY, 0);
    }

    
}