using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterOne : MonoBehaviour
{
        public float movementSpeed = 10.0f;
        private Rigidbody2D rb;
        private Rigidbody2D rb2;

        public GameObject secondPlayer;
        private GameObject characterTwo;

        void Start()
        {
                rb = GetComponent<Rigidbody2D>();	
                rb2 = secondPlayer.GetComponent<Rigidbody2D>();
        }


        void Swap()
        {
                var temp = transform.position;
                transform.position = secondPlayer.transform.position;
                secondPlayer.transform.position = temp;
                var _temp = rb.velocity;
                rb.velocity = rb2.velocity;
                rb2.velocity = _temp;
        }

        void Update()
        {
                if (Input.GetKeyDown(KeyCode.E))
                {
                        Swap();
                }
        }

        void FixedUpdate()
        {
                rb.velocity = new Vector3(Input.GetAxis("Horizontal") * movementSpeed, rb.velocity.y, 0);

        }
}
