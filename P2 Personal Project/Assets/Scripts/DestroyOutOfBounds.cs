using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        Collider collider = GetComponent<Collider>();
        Collider colliderOther = GetComponentInParent<SendCollider>().CannonCollider();
        Physics.IgnoreCollision(collider, colliderOther);
        transform.SetParent(null);
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(this.gameObject);
    }
}
