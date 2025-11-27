using UnityEngine;

public class ObjectMover : MonoBehaviour
{
    // Destination position to move the object
    public Vector3 destinationPosition;

    // Speed at which the object moves
    public float moveSpeed = 0.5f;

    // Time to wait before moving back to the original position
    public float waitTime = 2f;

    // Store the original position of the object
    private Vector3 originalPosition;

    void Start()
    {
        // Store the original position of the object
        originalPosition = transform.position;

        // Start moving the object
        MoveObject();
    }

    void MoveObject()
    {
        // Move the object to the destination position
        transform.position = Vector3.Lerp(originalPosition, destinationPosition, Mathf.PingPong(Time.time * moveSpeed, 1f));

        // If the object has reached the destination, wait for a specified time and then move back
        if (Vector3.Distance(transform.position, destinationPosition) < 0.01f)
        {
            // Wait for a specified amount of time
            Invoke("MoveBack", waitTime);
        }
        else
        {
            // Otherwise, keep moving towards the destination
            Invoke("MoveObject", Time.deltaTime);
        }
    }

    void MoveBack()
    {
        // Move the object back to its original position
        transform.position = Vector3.Lerp(destinationPosition, originalPosition, Mathf.PingPong(Time.time * moveSpeed, 1f));

        // If the object has reached the original position, wait for a specified time and then move to the destination again
        if (Vector3.Distance(transform.position, originalPosition) < 0.01f)
        {
            // Wait for a specified amount of time
            Invoke("MoveObject", waitTime);
        }
        else
        {
            // Otherwise, keep moving back towards the original position
            Invoke("MoveBack", Time.deltaTime);
        }
    }
}
