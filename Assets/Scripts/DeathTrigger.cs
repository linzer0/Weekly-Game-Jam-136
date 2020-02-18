using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathTrigger : MonoBehaviour
{

        private CharacterRespawner charResp;

        void Start()
        {
                charResp = GameObject.FindGameObjectWithTag("GameManager").GetComponent<CharacterRespawner>();
        }

        void OnTriggerEnter2D(Collider2D coll)
        {
                charResp.Respawn(coll.gameObject);
        }
}
