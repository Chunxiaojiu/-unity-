using UnityEngine;
using System.Collections;

public class pipe : MonoBehaviour {
    void Start() {
        RandomPosition();
    }
    public void RandomPosition() {
        float pos_y = Random.Range(-0.2f, -0.55f);
        this.transform.localPosition = new Vector3(this.transform.localPosition.x, pos_y, this.transform.localPosition.z);

    }
    void OnTriggerExit(Collider other) {
        if (other.tag == "Player") {
            GameManager.intance.scorce++;
        }
    }

    void OnGUI() {
        GUILayout.Label("得分：" + GameManager.intance.scorce);
    }
}
