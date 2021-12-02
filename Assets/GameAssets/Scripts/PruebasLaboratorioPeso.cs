using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PruebasLaboratorioPeso : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("WeightEnterTrigger");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("WeightEnterCollision");
    }
}
