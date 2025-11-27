using UnityEngine;
using System.Collections;

public class CameraSwitcher : MonoBehaviour
{
    public Camera firstCamera;
    public Camera secondCamera;

    void Start()
    {
        // Start with the second camera active
        secondCamera.gameObject.SetActive(true);

        // Switch back to the first camera after 1 second
        StartCoroutine(SwitchToFirstCameraAfterDelay(1f));
    }

    IEnumerator SwitchToFirstCameraAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);

        // Switch back to the first camera
        secondCamera.gameObject.SetActive(false);
        firstCamera.gameObject.SetActive(true);
    }
}
