using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 100;

    public GameObject deathEffect;

    public void TakeDamage (int damege)
    {
        health -= damege;

        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        var smierc = Instantiate(deathEffect);
        smierc.transform.position = transform.position;
        Destroy(gameObject);
    }
}
