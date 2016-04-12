using UnityEngine;
using System.Collections;

public class movetrigger : MonoBehaviour {
    public Transform currentbg;
    public pipe pipe1;
    public pipe pipe2;

    public void OnTriggerEnter(Collider other) {
        print("qidong");
        if (other.tag == "Player") {
          Transform fsbg =   GameManager.intance.fsbackground;
            currentbg.transform.position = new Vector3(fsbg.position.x + 10, currentbg.transform.position.y, currentbg.transform.position.z);
            GameManager.intance.fsbackground = currentbg;

            pipe1.RandomPosition();
            pipe2.RandomPosition();
        }
    }
}
