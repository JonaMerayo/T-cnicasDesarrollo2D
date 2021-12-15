using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class PlayerControllerB2D : MonoBehaviour
{
    [SerializeField] private float jumpForce = 300f;                            // Amount of force added when the player jumps.
    [SerializeField] private bool airControl = false;                           // Whether or not a player can steer while jumping;	
    public float runSpeed = 5.0f;

    float horizontal;
    bool jump;
    bool attack;
    private bool grounded = false;                                              // Whether or not the player is grounded.
    private new Rigidbody2D rigidbody2D;
    private bool facingRight = true;											// For determining which way the player is currently facing.
    private GameObject[] floorObjects;
    private new SpriteRenderer renderer;
    private Animator animator;


    private void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();

        floorObjects = GameObject.FindGameObjectsWithTag("Floor");
        renderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //horizontal = Input.GetAxisRaw("Horizontal");

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            horizontal = -1;
        }

        else if (Input.GetKey(KeyCode.RightArrow))
        {
            horizontal = 1;
        }

        else
        {
            horizontal = 0;
        }

        jump = Input.GetKey(KeyCode.UpArrow); // Input.GetKeyDown("space");
        attack = Input.GetKey(KeyCode.DownArrow);
    }

    private void FixedUpdate()
    {
        // The player is grounded if any Floor collider is touching his collider.
        if (floorObjects.Length > 0)
        {
            foreach (var obj in floorObjects)
            {
                if (obj.GetComponent<Collider2D>().IsTouching(GetComponent<Collider2D>()))
                {
                    grounded = true;
                }
            }
        }

        Move();
    }

    public void Move()
    {
        //Debug.Log(velocity.x);
        //Debug.Log(grounded);

        //Only control the player if grounded or airControl is turned on
        if (grounded || airControl)
        {
            //Move the player
            rigidbody2D.velocity = new Vector2(horizontal * runSpeed, rigidbody2D.transform.position.y);
            float move = rigidbody2D.velocity.x;
            animator.SetFloat("MoveX", move);
            //Debug.Log(move);

            // If the input is moving the player right and the player is facing left...
            if (move > 0 && !facingRight)
            {
                // ... flip the player.
                Flip();
            }
            // Otherwise if the input is moving the player left and the player is facing right...
            else if (move < 0 && facingRight)
            {
                // ... flip the player.
                Flip();
            }
        }

        // If the player should jump...
        if (grounded && jump)
        {
            // Add a vertical force to the player.
            grounded = false;
            rigidbody2D.AddForce(new Vector2(0f, jumpForce));
            //renderer.flipX = facingRight;
        }
    }

    private void Flip()
    {
        //And use flip to change position and update facingRight
        renderer.flipX = facingRight;
        facingRight = !renderer.flipX;

        //// Multiply the player's x local scale by -1.
        //Vector3 theScale = transform.localScale;
        //theScale.x *= -1;
        //transform.localScale = theScale;
    }

    IEnumerator DelayAction(float delayTime)
    {
        //Wait for the specified delay time before continuing.
        yield return new WaitForSeconds(delayTime);

        //Do the action after the delay time has finished.
    }
}