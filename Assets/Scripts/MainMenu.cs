using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] Text highestScoreText;
    void Start()
    {
        
    }
    
    void Update()
    {
        highestScoreText.text = "Highest Score: " + GameManager.highestScore;
    }

    public void LoadGame()
    {
        SceneManager.LoadScene(1);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
