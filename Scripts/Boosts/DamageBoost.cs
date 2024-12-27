using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageBoost : MonoBehaviour
{
    public float damageMult = 1.5f;
    void OnTriggerEnter(Collider other)
    {
        Bullet.playerDamage *= damageMult;
        Destroy(gameObject);
    }
}
