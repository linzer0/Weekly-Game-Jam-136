using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterTwo : MonoBehaviour
{
        private Rigidbody2D rb;

        private bool isGrounded;

        public GameObject firstPlayer;
        public float movementSpeed = 10.0f;
        public float jumpPower = 20.0f;

        // Use this for initialization
        void Start()
        {
                isGrounded = true;
                rb = GetComponent<Rigidbody2D>();
        }
	
        void Jump()
        {
                rb.AddForce(new Vector2(0, jumpPower), ForceMode2D.Impulse);
        }

        void Swap()
        {
                var temp = transform.position;
                transform.position = firstPlayer.transform.position;
                firstPlayer.transform.position = temp;
                var _temp = rb.velocity;
                rb.velocity = firstPlayer.GetComponent<Rigidbody2D>().velocity;
                firstPlayer.GetComponent<Rigidbody2D>().velocity = _temp;
        }
        void OnCollisionEnter2D(Collision2D collision)
        {
                if (collision.gameObject.tag == "Ground")
                        isGrounded = true;
        }

        // Update is called once per frame
        void Update()
        {
                rb.velocity = new Vector3(Input.GetAxis("Horizontal1") * movementSpeed, rb.velocity.y, 0);
                if (Input.GetButtonDown("Jump1") && isGrounded)
                {
                        Jump();
                        isGrounded = false;
                }
                if (Input.GetButtonDown("Fire1"))
                {
                        Swap();
                }
        }
}
