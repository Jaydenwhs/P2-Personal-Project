using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
   public GameObject projectilePrefab;
   public float speed;
   public float turnSpeed;
   public float horizontalInput;
    

    [SerializeField] private Shooty shooty;

    // Start is called before the first frame update
    void Start()
    {
     

    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetKey(KeyCode.LeftArrow))
         {
            this.transform.Translate (new Vector3 (0f, 0f, speed) * Time.deltaTime,Space.Self);
         }
         if (Input.GetKey (KeyCode.RightArrow))
         {
            this.transform.Translate (new Vector3 (0f, 0f, -speed) * Time.deltaTime,Space.Self);
         }

         if (Input.GetKey (KeyCode.UpArrow))
         {
            shooty.RotateCanon(1);
         }
         if (Input.GetKey (KeyCode.DownArrow))
         {
              shooty.RotateCanon(-1);
         }
        
        if(Input.GetKeyDown(KeyCode.Return))
        {
            shooty.Shoot();
        }
    }
}
