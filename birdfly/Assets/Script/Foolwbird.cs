using UnityEngine;
using System.Collections;

public class Foolwbird : MonoBehaviour {
    public GameObject Bird;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 birdpos = Bird.transform.position;
        this.transform.position = new Vector3(birdpos.x+ 2.258974f, 0, birdpos.z - 6);
	}
}
