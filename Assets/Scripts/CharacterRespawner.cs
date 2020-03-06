using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterRespawner : MonoBehaviour
{
        public Transform respawnZoneCharacterOne;
        public Transform respawnZoneCharacterTwo;

        public void Respawn(GameObject gameObject)
        {
                if (gameObject.tag == "CharacterOne")
                        gameObject.transform.position = respawnZoneCharacterOne.position;
                else
                        gameObject.transform.position = respawnZoneCharacterTwo.position;
        }

        void Update()
        {
                if (Input.GetKeyDown(KeyCode.R))
                {
                        Application.LoadLevel(Application.loadedLevel);
                }
        }

}
