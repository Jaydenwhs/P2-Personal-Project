using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 40.0f;
    
    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddRelativeForce(Vector3.forward * speed, ForceMode.Impulse);
    }
}
