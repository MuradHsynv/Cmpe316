using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoost : MonoBehaviour
{
    public float speedMult = 1.5f;
    void OnTriggerEnter(Collider other)
    {
        PlayerMotor.speed *= speedMult;
        Destroy(gameObject);
    }
}
