using UnityEngine;
using System.Collections;

public class Bird : MonoBehaviour {
    public float time = 0;
    public int frameNumber = 10;
    public int frameCount = 0;
    public Material material;
    public Rigidbody brid;
    
    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        if (GameManager.intance.GAMESTATE == GameManager.GAMESTATE_PLAY)
        {
            time += Time.deltaTime;
            if (time >= 1.0f / frameNumber)
            {
                frameCount++;
                time -= 1.0f / frameNumber;
                int frameIndex = frameCount % 3;
                material.SetTextureOffset("_MainTex", new Vector2(0.33333f * frameIndex, 0));
            }



            if (Input.GetMouseButtonDown(0))
            {
                Vector3 vel = brid.velocity;
                brid.velocity = new Vector3(vel.x, 5, vel.z);
            }
        }
	}
    public void Getlife() {
        brid.useGravity = true;
        this.brid.velocity = new Vector3(3, 0, 0);
        
    }
}
