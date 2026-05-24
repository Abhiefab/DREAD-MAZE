using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimeController : MonoBehaviour
{
    public Text timeText;

    float time1 = 120f;

    void Update()
    {
        time1 -= Time.deltaTime;

        // Prevent negative values
        if (time1 < 0)
        {
            time1 = 0;
        }

        // Convert time into minutes and seconds
        int minutes = Mathf.FloorToInt(time1 / 60);
        int seconds = Mathf.FloorToInt(time1 % 60);

        // Display format: 2:00
        timeText.text =   minutes + ":" + seconds.ToString("00");

        // Game over when timer ends
        if (time1 <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}