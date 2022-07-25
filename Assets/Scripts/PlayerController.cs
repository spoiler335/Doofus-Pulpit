using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed =8f;
    [SerializeField] GameObject gameOverPanel;
    
    // Start is called before the first frame update
    void Start()
    {
        gameOverPanel.SetActive(false);
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        float xDirection = Input.GetAxis("Horizontal");
        float zDirection = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3 (xDirection,0f,zDirection);

        transform.position += moveDirection*speed/100f;

        if(transform.position.y < 0.7f)
        {
            gameOverPanel.SetActive(true);
            Time.timeScale =0f;
        }
    }

    

    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.CompareTag("Ground"))
        {
            Debug.Log("point");
            ++GameManager.Instance.Score;

            GameManager.highestScore = Mathf.Max(GameManager.Instance.Score, GameManager.highestScore);
        }
    }
}
