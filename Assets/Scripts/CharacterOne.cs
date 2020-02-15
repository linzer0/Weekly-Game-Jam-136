using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterOne : MonoBehaviour
{
        public float movementSpeed = 10.0f;
        private Rigidbody2D rb;
        public GameObject secondPlayer;

        public float pushPower = 5.0f;
        public float pushDistance = 5.0f;

        private GameObject characterTwo;

        void Start()
        {
                rb = GetComponent<Rigidbody2D>();	
        }


        void Push()
        {
                Rigidbody2D rb2 = secondPlayer.GetComponent<Rigidbody2D>();
                rb2.AddForce(new Vector2(pushPower, 0), ForceMode2D.Impulse);
        }

        void Update()
        {
                rb.velocity = new Vector3(Input.GetAxis("Horizontal") * movementSpeed, rb.velocity.y, 0);
                if (Input.GetKeyDown(KeyCode.E))
                {
                        Push();
                }
        }
}
