using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundManager : MonoBehaviour
{

    [SerializeField] GameObject groundPrefab;

    public static int floorCount=1;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
       if(floorCount < 2)
       {
            //spawnFloor();
            StartCoroutine(spawnFloor());
            int randInt = Random.Range(0, 4);
             //Debug.Log(randInt);
            // if(randInt == 0)
            // {
            //     spawnForwards();
            // }

            // else if (randInt == 1)
            // {
            //     spawnBackwards();
            // }

            // else if (randInt == 2)
            // {
            //     spawanLeft();
            // }

            // else if (randInt == 3)
            // {
            //     spawnRight();
            // }
       }
    }

    IEnumerator spawnFloor()
    {
        
        yield return new WaitForSeconds(2f);
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
        ++floorCount;
    }

    void spawnBackwards()
    {
        Vector3 newPos = new Vector3(transform.position.x , transform.position.y, transform.position.z-9f);
        transform.position = newPos;
        Instantiate(groundPrefab, newPos, transform.rotation);
        ++floorCount;
    }

    void spawanLeft()
    {
        Vector3 newPos = new Vector3(transform.position.x - 9f, transform.position.y, transform.position.z);
        transform.position = newPos;
        Instantiate(groundPrefab, newPos, transform.rotation);
        ++floorCount;
    }

    void spawnRight()
    {
        Vector3 newPos = new Vector3(transform.position.x + 9f, transform.position.y, transform.position.z);
        transform.position = newPos;
        Instantiate(groundPrefab, newPos, transform.rotation);
        ++floorCount;
    }

}
