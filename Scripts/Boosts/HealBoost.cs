using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealBoost : MonoBehaviour
{
    public float healAmount = 50f;
    void OnTriggerEnter(Collider other)
    {
        PlayerHealth.health += healAmount;
        Destroy(gameObject);
    }
}
