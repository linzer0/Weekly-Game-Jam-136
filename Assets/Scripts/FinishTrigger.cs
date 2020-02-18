using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishTrigger : MonoBehaviour
{

        private int CharacterInsideTrigger = 0;

        void LevelFinish()
        {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        void OnTriggerEnter2D(Collider2D coll)
        {
                if (coll.gameObject.tag == "CharacterOne" || coll.gameObject.tag == "CharacterTwo")
                        CharacterInsideTrigger++;
                if (CharacterInsideTrigger == 2)
                {
                        LevelFinish();
                }
        }

        void OnTriggerExit2D(Collider2D coll)
        {
                if (coll.gameObject.tag == "CharacterOne" || coll.gameObject.tag == "CharacterTwo")
                        CharacterInsideTrigger--;
        }
}
