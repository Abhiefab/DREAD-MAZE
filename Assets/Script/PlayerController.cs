using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5f;
    [SerializeField] float rotationSpeed = 500f;
    Quaternion targetRotation;
    Vector2 startingPostion;


    CameraController cameraController;
   private CharacterController characterController;
    Animator animator;
   


    private void Awake()
    {

        cameraController = Camera.main.GetComponent<CameraController>();
        characterController = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();

    }
    private void Start()
    {
        startingPostion = transform.position;
        characterController  = GetComponent<CharacterController> ();
       

        
    }
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.collider.CompareTag("end"))
        {
            SceneManager.LoadScene("EndScreen");
           
        }
        if (hit.collider.CompareTag("moveWalls"))
        {
            SceneManager.LoadScene("GameOver");
        }
        
    }




    private void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        float moveAmount = Mathf.Clamp01(Mathf.Clamp01(Mathf.Abs(h) + Mathf.Abs(v)));

        var moveInput = (new Vector3(h, 0, v)).normalized;

        var moveDir = cameraController.GetPlannerRotation() * moveInput;


        if (moveAmount > 0)
        {
            characterController.Move(moveDir * moveSpeed * Time.deltaTime);

            targetRotation = Quaternion.LookRotation(moveDir);


        }
        transform.rotation = Quaternion.RotateTowards(transform.rotation,
         targetRotation, rotationSpeed * Time.deltaTime);
        animator.SetFloat("moveAmount", moveAmount, 0.2f, Time.deltaTime);
    }
    

} 