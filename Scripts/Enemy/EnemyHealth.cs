using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    private float health;
    public float maxHealth = 50f;

    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        health = Mathf.Clamp(health, 0, maxHealth);
    }

    public void EnemyTakeDamage(float damage)
    {
        health -= damage;    
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }


    

}