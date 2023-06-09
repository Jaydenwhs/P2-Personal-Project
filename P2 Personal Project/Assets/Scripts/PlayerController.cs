using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject projectilePrefab;
    public float speed = 5;
    public float turnSpeed;
    public float horizontalInput;

    [SerializeField] private Shooty shooty;

    // Update is called once per frame
  
    void Start()
    {
        
    }
  
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        //move tanks left/right
        transform.Translate(Vector3.forward * Time.deltaTime * speed * horizontalInput);
       
        if(Input.GetKeyDown(KeyCode.Space))
        {
            shooty.Shoot();
        }

        if(Input.GetKey(KeyCode.S))
        {
            shooty.RotateCanon(-1);
        }

        if(Input.GetKey(KeyCode.W))
        {
            shooty.RotateCanon(1);
        }
    }
     
}
