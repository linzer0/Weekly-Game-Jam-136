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

        void OnTriggerEnter2D(Collider2D collider)
        {
                foreach (var item in jumpableTags)
                {
                        if (collider.gameObject.tag == item)
                                charTwo.isGrounded = true;
                }
        }
}
