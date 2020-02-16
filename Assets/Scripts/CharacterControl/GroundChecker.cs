using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundChecker : MonoBehaviour
{
        CharacterTwo charTwo;

        private List<string> jumpableTags;

        void Start()
        {
                charTwo = GameObject.FindGameObjectWithTag("CharacterTwo").GetComponent<CharacterTwo>();

                jumpableTags = new List<string>();
                jumpableTags.Add("Ground");
                jumpableTags.Add("CharacterOne");
        }

        void OnCollisionEnter2D(Collision2D collision)
        {
                foreach (var item in jumpableTags)
                {
                        if (collision.gameObject.tag == item)
                                charTwo.isGrounded = true;
                }
        }
}
