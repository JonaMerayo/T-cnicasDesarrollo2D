using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PruebasLaboratorioMadera : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("PrankEnterTrigger");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("PrankEnterCollision");
    }
}
