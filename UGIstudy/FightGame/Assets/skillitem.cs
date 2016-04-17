using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class skillitem : MonoBehaviour {
    public float coldtime = 2;
    private float time = 0;
    private Image fillimage;
    private bool isStarttime = false;
	// Use this for initialization
	void Start () {
        fillimage = transform.Find("fillimage").GetComponent<Image>();

	}
	
	// Update is called once per frame
	void Update () {
        if (isStarttime) {
            time += Time.deltaTime;
            fillimage.fillAmount = (coldtime - time) / coldtime;
            if (time >= coldtime) {
                isStarttime = false;
                time = 0;
                fillimage.fillAmount = 0;
            }
        }
	}
    public void Onclick() {
        isStarttime = true;
    }
}
