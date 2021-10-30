using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    [SerializeField] int health = 3;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Whip"))
        {
            TakeDamage();
        }
    }

    void TakeDamage()
    {
        health--;
        if(health <= 0)
        {
            Destroy(gameObject);
        }
    }

}
