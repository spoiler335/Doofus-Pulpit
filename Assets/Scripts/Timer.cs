using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    float time = 4.00f;

    [SerializeField] TextMeshPro timerText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        timerText.text = time.ToString(".00");

        

        if(time <= 0)
        {
            Destroy(gameObject,0.1f);
            --GroundManager.floorCount;
        }
    }

   
}
