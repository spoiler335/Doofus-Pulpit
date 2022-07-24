using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    float time = 4.00f;

    [SerializeField] TextMeshPro timerText;
    [SerializeField] GameObject groundPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        timerText.text = time.ToString(".00");

        // if(time <= 2.5f)
        // {
        //     int r = Random.Range(0,4);
        //     Debug.Log("r = "+r);
        //     if(r == 0)
        //     {
        //         Instantiate(groundPrefab,transform.position + new Vector3(0,0,9f),transform.rotation);
        //     }

        //     if (r == 1)
        //     {
        //         Instantiate(groundPrefab,transform.position + new Vector3(0,0,-9f),transform.rotation);
        //     }

        //     if (r == 2)
        //     {
        //         Instantiate(groundPrefab,transform.position + new Vector3(-9f,0,0),transform.rotation);
        //     }

        //     if (r == 3)
        //     {
        //         Instantiate(groundPrefab,transform.position + new Vector3(9f,0,0),transform.rotation);
        //     }
        // }

        if(time <= 0)
        {
            Destroy(gameObject,0.1f);
        }
    }

    // void spawnForwards()
    // {
    //     Vector3 newPos = new Vector3(transform.position.x , transform.position.y, transform.position.z+9f);
    //     transform.position = newPos;
    //     Instantiate(groundPrefab, newPos, transform.rotation);
    // }

    // void spawnBackwards()
    // {
    //     Vector3 newPos = new Vector3(transform.position.x , transform.position.y, transform.position.z-9f);
    //     transform.position = newPos;
    //     Instantiate(groundPrefab, newPos, transform.rotation);
    // }

    // void spawanLeft()
    // {
    //     Vector3 newPos = new Vector3(transform.position.x - 9f, transform.position.y, transform.position.z);
    //     transform.position = newPos;
    //     Instantiate(groundPrefab, newPos, transform.rotation);
    // }

    // void spawnRight()
    // {
    //     Vector3 newPos = new Vector3(transform.position.x + 9f, transform.position.y, transform.position.z);
    //     transform.position = newPos;
    //     Instantiate(groundPrefab, newPos, transform.rotation);
    // }
}
