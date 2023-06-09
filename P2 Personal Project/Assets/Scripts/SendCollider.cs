using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendCollider : MonoBehaviour
{
    public Collider CannonCollider()
    {
        Collider collider = GetComponent<Collider>();

        return collider;
    }
}
