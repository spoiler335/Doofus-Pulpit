using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundManager : MonoBehaviour
{

    [SerializeField] GameObject groundPrefab;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // StartCoroutine(spawnFloor());
       Invoke("spawnFloor",2f);
    
    }

    void spawnFloor()
    {
        //yield return new WaitForSeconds(2f);
        int randInt = Random.Range(0, 4);
        //Debug.Log(randInt);
        if(randInt == 0)
        {
            spawnForwards();
        }

        else if (randInt == 1)
        {
            spawnBackwards();
        }

        else if (randInt == 2)
        {
            spawanLeft();
        }

        else if (randInt == 3)
        {
            spawnRight();
        }
        //yield return new WaitForSeconds(2f);
    }


    void spawnForwards()
    {
        Vector3 newPos = new Vector3(transform.position.x , transform.position.y, transform.position.z+9f);
        transform.position = newPos;
        Instantiate(groundPrefab, newPos, transform.rotation);
    }

    void spawnBackwards()
    {
        Vector3 newPos = new Vector3(transform.position.x , transform.position.y, transform.position.z-9f);
        transform.position = newPos;
        Instantiate(groundPrefab, newPos, transform.rotation);
    }

    void spawanLeft()
    {
        Vector3 newPos = new Vector3(transform.position.x - 9f, transform.position.y, transform.position.z);
        transform.position = newPos;
        Instantiate(groundPrefab, newPos, transform.rotation);
    }

    void spawnRight()
    {
        Vector3 newPos = new Vector3(transform.position.x + 9f, transform.position.y, transform.position.z);
        transform.position = newPos;
        Instantiate(groundPrefab, newPos, transform.rotation);
    }

}
