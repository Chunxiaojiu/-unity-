using UnityEngine;
using System.Collections;

public class pipeUporDown : MonoBehaviour {

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            GameManager.intance.GAMESTATE = GameManager.GAMESTATE_END;
        }
    }
}
