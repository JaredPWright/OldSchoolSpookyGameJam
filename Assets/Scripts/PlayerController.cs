using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Player Rigidbody
    private Rigidbody2D playerRigidbody;
    //Player Collider
    private BoxCollider2D playerCollider;
    //Player's Sprite Renderer
    private SpriteRenderer spriteRenderer;
    //Is the player on the ground
    public static bool grounded = false;

    //Player Speed
    public float playerSpeed = 5.0f;
    [SerializeField] bool isMoving;
    //Player Jump
    public float playerJump = 5.0f;

    //Crouch
    [SerializeField] bool isCrouching;

    void Start()
    {
        //Get the Player Rigidbody
        playerRigidbody = GetComponent<Rigidbody2D>();
        //Get the Player Collider
        playerCollider = GetComponent<BoxCollider2D>();
        //Get the Sprite Renderer
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (Input.GetAxis("Horizontal") != 0f && !isCrouching)
        {
            playerRigidbody.AddForce(transform.right * Input.GetAxis("Horizontal") * playerSpeed, ForceMode2D.Force);

            isMoving = true;
        }
        else
        {
            isMoving = false;
        }

        if (Input.GetAxis("Horizontal") < 0f)
        {
            spriteRenderer.flipX = true;
        }
        else
        {
            spriteRenderer.flipX = false;
        }
        if (Input.GetButtonDown("Jump") && grounded)
        {
            playerRigidbody.AddForce(transform.up * playerJump, ForceMode2D.Impulse);
        }

        Crouch();
    }

    void Crouch()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            isCrouching = true;

            //Changes the BoxCollider2d size and offset to make it half the size it was
            playerCollider.size = new UnityEngine.Vector3(1.25f, .615f, 0f);
            playerCollider.offset = new UnityEngine.Vector3(-0.02102536f, -0.49f, 0f);

        }
        else if (Input.GetKeyUp(KeyCode.S))
        {
            isCrouching = false;

            //Changes the BoxCollider2d to go back to normal
            playerCollider.size = new UnityEngine.Vector3(1.25f, 1.23f, 0f);
            playerCollider.offset = new UnityEngine.Vector3(-0.02102536f, -0.1892284f, 0f);

        }
    }

    void Slide()
    {
        if (isMoving && isCrouching)
        {

        }
    }
}
