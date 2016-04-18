using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
    public float speed = 90;
	// Update is called once per frame
	void Update () {
        
        transform.Rotate(new Vector3(0, 1, 0) * Time.deltaTime * speed);//Vector3.up
	}
    public void changspeed(float newspeed) {
        this.speed = newspeed;
    }
}
