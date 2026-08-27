using UnityEngine;

public class Pause : MonoBehaviour
{
    public GameObject helpPanel;

    bool isPaused;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("h"))
        {
            TogglePause();
        }
    }

    public void TogglePause()
    {
        isPaused = !isPaused;
        helpPanel.SetActive(isPaused);
        Time.timeScale = isPaused ? 0f : 1f;
    }

    public void Resume()
    {
        isPaused = false;
        helpPanel.SetActive(false);
        Time.timeScale = 1f;
    }
}
