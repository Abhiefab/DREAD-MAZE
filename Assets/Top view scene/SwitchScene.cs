using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class SceneSwitcher : MonoBehaviour
{
    void Start()
    {
        // Start the coroutine to switch scenes after 1 second
        StartCoroutine(SwitchSceneAfterDelay());
    }

    IEnumerator SwitchSceneAfterDelay()
    {
        // Wait for 1 second
        yield return new WaitForSeconds(1f);

        // Switch to the desired scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
