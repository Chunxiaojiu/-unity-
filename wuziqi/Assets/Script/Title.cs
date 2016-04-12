using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Title : MonoBehaviour {

    public Button StartButton;
    public Button ExitButton;
    public Button DoubleButton;
    // board窗口
    public GameObject board;
    public MainLoop loop;
   
	// Use this for initialization
	void Start () {
        StartButton.onClick.AddListener(() =>
        {
            gameObject.SetActive(false);
            board.SetActive(true);
        });

        ExitButton.onClick.AddListener(() =>
        {
            Application.Quit();
        });
        DoubleButton.onClick.AddListener(() => {
            gameObject.SetActive(false);
            board.SetActive(true);
            loop.SetTwopersonGameStyle();
        });
    }
	
}
