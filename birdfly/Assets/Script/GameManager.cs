using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
    public Transform fsbackground;
    public static GameManager intance;
    public  int scorce = 0;
    public static int GAMESTATE_MENU = 0;
    public static int GAMESTATE_PLAY = 1;
    public static int GAMESTATE_END  = 2;
    public int GAMESTATE = GAMESTATE_MENU;
    private GameObject bird;
    void Awake() {
        intance = this;
        bird = GameObject.FindGameObjectWithTag("Player");
    }
    void Update() {
        if (GAMESTATE == GAMESTATE_MENU) {
            if (Input.GetMouseButtonDown(0)) {
                GAMESTATE = GAMESTATE_PLAY;
                bird.SendMessage("Getlife");
            }
        }
    }
}
