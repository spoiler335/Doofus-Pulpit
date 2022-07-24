using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed =8f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xDirection = Input.GetAxis("Horizontal");
        float zDirection = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3 (xDirection,0f,zDirection);

        transform.position += moveDirection*speed/100f;
    }

    // private void OnTriggerEnter(Collider other) 
    // {
    //     if(other.CompareTag("Ground"))
    //     {
    //         other.GetComponent<BoxCollider>().isTrigger =false;
    //     }    
    // }

    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.CompareTag("Ground"))
        {
            Debug.Log("point");
            ++GameManager.Instance.Score;
        }
    }
}
