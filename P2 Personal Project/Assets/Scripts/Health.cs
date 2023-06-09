using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = 100;   
    }

    public void takeDamage(int amount)
    {
        currentHealth-= amount;

        if(currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
      
      public void OnCollisionEnter(Collision col)
    {
      if (col.gameObject.tag == "Bullet")
        {
        takeDamage(5);
        }
          
     }
     
}   

