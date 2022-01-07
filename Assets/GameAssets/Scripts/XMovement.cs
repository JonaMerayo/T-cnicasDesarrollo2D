using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XMovement : MonoBehaviour
{
    public float speedX;
    public bool waitForPlayerStart;

    private bool playerHasMoved;
    private PlayerController2D playerCon;
    private Rigidbody2D rb;
    
    // Start is called before the first frame update
    void Start()
    {
        if (waitForPlayerStart)
        {
            playerHasMoved = false;

            // We recover player delegated events script
            playerCon = GameObject.FindWithTag("Player").GetComponent<PlayerController2D>();
            playerCon.OnFirstPlayerMove += startToMoveThis;
        }
        else
        {
            playerHasMoved = true;
        }
        
        rb = GetComponent<Rigidbody2D>();        
    }

    private void FixedUpdate()
    {
        if (playerHasMoved)
        {
            move();
        }
        //Debug.Log(playerHasMoved);
    }

    private void move()
    {
        //Move the player
        rb.velocity = new Vector2(speedX, rb.transform.position.y);

    }

    private void startToMoveThis()
    {
        playerHasMoved = true;
    }
}
