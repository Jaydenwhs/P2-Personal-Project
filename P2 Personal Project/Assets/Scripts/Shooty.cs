using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooty : MonoBehaviour
{
    [SerializeField] private Transform cannonTransform;
    public GameObject projectilePrefab;
    public float rotationSpeed = 30;

    public void RotateCanon(int direction)
    {
        cannonTransform.Rotate(Vector3.left * rotationSpeed * Time.deltaTime * direction);
    }

    public void Shoot()
    {
        GameObject projectile = Instantiate(projectilePrefab, transform.position, transform.rotation); // projectile rotation not going in right direction.
        projectile.transform.SetParent(transform);
    }
}
