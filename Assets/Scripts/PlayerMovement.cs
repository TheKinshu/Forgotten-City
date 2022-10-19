using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D playerBody;
    private BoxCollider2D coll;
    private Animator playerAnimation;
    private SpriteRenderer sprite;
    private float dirX;
    private float dirY;

    [SerializeField] private float moveSpeed = 7f;
    [SerializeField] private float jumpForce = 14f;
    [SerializeField] private LayerMask jumpableGround;

    private enum MovementState { idle, running, jumping, falling}

    // Start is called before the first frame update
    private void Start()
    {
        playerBody =  GetComponent<Rigidbody2D>();
        playerAnimation = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
        coll = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        dirX = Input.GetAxis("Horizontal"); 
        playerBody.velocity = new Vector2(dirX * moveSpeed, playerBody.velocity.y);

        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            playerBody.velocity = new Vector2(playerBody.velocity.x, jumpForce);
        }

        UpdateAnimationState();
    }

    private void UpdateAnimationState()
    {
        MovementState state;

        if (dirX > 0f)
        {
            state = MovementState.running;
            sprite.flipX = false;
        }
        else if (dirX < 0f)
        {
            state = MovementState.running;
            sprite.flipX = true;
        }
        else
        {
            state = MovementState.idle;
        }

        if (playerBody.velocity.y > .1f)
        {
            state = MovementState.jumping;
        }
        else if (playerBody.velocity.y < -.1f)
        {
            state = MovementState.falling;
        }

        playerAnimation.SetInteger("state", (int)state);
    }

    private bool IsGrounded()
    {
        return Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, 0f, Vector2.down, 0.1f, jumpableGround);
    }
}
