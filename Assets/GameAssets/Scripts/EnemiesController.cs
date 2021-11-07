using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesController : MonoBehaviour
{
    private bool lookForDanger;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator=GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        lookForDanger = Input.GetKey(KeyCode.X);
        if (lookForDanger)
        {
            animator.Play("LookingAround");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log(collision.gameObject.name);
        collision.gameObject.GetComponent<Animator>().Play("BlowUp");
        collision.gameObject.GetComponent<SpriteRenderer>().sprite=null;
        animator.Play("Die");
    }
    
}
