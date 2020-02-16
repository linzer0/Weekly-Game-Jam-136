using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishTrigger : MonoBehaviour {

        private int CharacterInsideTrigger = 0;

        void LevelFinish()
        {
                Debug.Log("Level finished");
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
