using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterTwo : MonoBehaviour
{
        private Rigidbody2D rb;

        public bool isGrounded;

        public GameObject firstPlayer;
        public float movementSpeed = 10.0f;
        public float jumpPower = 20.0f;

        void Start()
        {
                isGrounded = true;
                rb = GetComponent<Rigidbody2D>();
        }

        void Jump()
        {
                rb.AddForce(new Vector2(0, jumpPower), ForceMode2D.Impulse);
        }

       
        void Update()
        {
                rb.velocity = new Vector3(Input.GetAxis("Horizontal1") * movementSpeed, rb.velocity.y, 0);
                if (Input.GetButtonDown("Jump1") && isGrounded)
                {
                        Jump();
                        isGrounded = false;
                }
        }
}
