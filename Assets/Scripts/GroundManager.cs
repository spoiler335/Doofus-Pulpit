using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundManager : MonoBehaviour
{

    [SerializeField] GameObject groundPrefab;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(Instantiate(groundPrefab, transform.position, transform.rotation), 4f*Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(spawnFloor());
        

    }

    IEnumerator spawnFloor()
    {
        int randInt = Random.Range(0, 4);
        Debug.Log(randInt);
        if(randInt == 0)
        {
            spawnForwards();
        }

        if (randInt == 1)
        {
            spawnBackwards();
        }

        if (randInt == 2)
        {
            spawanLeft();
        }

        if (randInt == 3)
        {
            spawnRight();
        }
        yield return new WaitForSeconds(2f*Time.deltaTime);
    }


    void spawnForwards()
    {
        Vector3 newPos = new Vector3(transform.position.x , transform.position.y, transform.position.z+9f);
        transform.position = newPos;
        Destroy(Instantiate(groundPrefab, newPos, transform.rotation), 4f*Time.deltaTime);
    }

    void spawnBackwards()
    {
        Vector3 newPos = new Vector3(transform.position.x , transform.position.y, transform.position.z-9f);
        transform.position = newPos;
        Destroy(Instantiate(groundPrefab, newPos, transform.rotation), 4f * Time.deltaTime);
    }

    void spawanLeft()
    {
        Vector3 newPos = new Vector3(transform.position.x - 9f, transform.position.y, transform.position.z);
        transform.position = newPos;
        Destroy(Instantiate(groundPrefab, newPos, transform.rotation), 4f * Time.deltaTime);
    }

    void spawnRight()
    {
        Vector3 newPos = new Vector3(transform.position.x + 9f, transform.position.y, transform.position.z);
        transform.position = newPos;
        Destroy(Instantiate(groundPrefab, newPos, transform.rotation), 4f * Time.deltaTime);
    }

}
