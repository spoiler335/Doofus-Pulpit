using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    [SerializeField] Text scoreText;
    [SerializeField] Text highestScoreText;

    [SerializeField] GameObject pauseMenuPanel;
    bool isPaused;

    // Start is called before the first frame update
    void Start()
    {
        pauseMenuPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + GameManager.Instance.Score;
        highestScoreText.text = "Highest Score: " + GameManager.highestScore;

        if(Input.GetKey(KeyCode.Escape))
        {
            if(isPaused)
            {
                Resume();
            }

            else
            {
                Pause();
            }
        }

    }

    void Pause()
    {
        pauseMenuPanel.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    void Resume()
    {
        pauseMenuPanel.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    public void loadMainMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
        isPaused = false;
    }

}
