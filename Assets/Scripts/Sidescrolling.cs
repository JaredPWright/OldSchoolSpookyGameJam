using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

namespace Sidescrolling
{
    public class Movement : MonoBehaviour
    {
        //Player Rigidbody
        private Rigidbody2D playerRigidbody;
        //Player's Sprite Renderer
        private SpriteRenderer spriteRenderer;
        //Is the player on the ground
        public static bool grounded = false;

        //Player Speed
        public float playerSpeed = 5.0f;
        //Player Jump
        public float playerJump = 5.0f;

        void Start()
        {
            //Get the Player Rigidbody
            playerRigidbody = GetComponent<Rigidbody2D>();
        }

        void Update()
        {
            if(Input.GetAxis("Horizontal") != 0f)
            {
                playerRigidbody.AddForce(transform.forward * Input.GetAxis("Horizontal") * playerSpeed, ForceMode2D.Force);
            }

            if(Input.GetAxis("Horizontal") < 0f)
            {
                spriteRenderer.flipX = true;
            }else
                spriteRenderer.flipX = false;

            if(Input.GetButtonDown("Jump") && grounded)
            {
                playerRigidbody.AddForce(transform.up * playerJump, ForceMode2D.Impulse);
            }
        }
    }

    public class PlayerCollisionDetection : MonoBehaviour
    {
        [SerializeField] Vector2 normalCheck = new Vector2(0.0f, -1.0f);
        void OnCollisionEnter2D(Collision2D collision)
        {
            foreach(ContactPoint2D contact in collision.contacts)
            {
                if(contact.normal.y == normalCheck.y)
                {
                   Movement.grounded = true;
                }
            }
        }

        void OnCollisionExit2D(Collision2D collision)
        {
            Movement.grounded = false;
        }
    }
}