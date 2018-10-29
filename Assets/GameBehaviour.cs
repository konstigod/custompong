using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBehaviour : MonoBehaviour {


    HUD hud;
    public BoxCollider2D goal1;
    public BoxCollider2D goal2;
    BallBehaviour ballBeh;
    Playerctrl player1;
    Playerctrl player2;
    // Use this for initialization


    int[] score = new int[] { 0, 0 };
    public int maxScore;
    private string Playerscore;

    void Start() {
        hud = GameObject.Find("HUD").GetComponent<HUD>();
        ballBeh = GameObject.Find("Ball").GetComponent<BallBehaviour>();
        player1 = GameObject.Find("Player1").GetComponent<Playerctrl>();
        player2 = GameObject.Find("Player2").GetComponent<Playerctrl>();

    }

    // Update is called once per frame
    void Update() {

    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("trigger");
    }

    public void goalScored(int index)
    {
        score[index] += 1;
        Debug.Log("Goal Scored! The current score is: " + score[0] + ": " + score[1]);
        hud.setscore(score);
       
        if(score[0] >= maxScore)
        {
            Debug.Log("Game Over. Player 1 won");
            score = new int[] { 0, 0 };
        }
        else if (score[1] >= maxScore)
        {
            Debug.Log("Game Over. Player 2 won");
            score = new int[] { 0, 0 };
        }
        ballBeh.reset();
        player1.reset();
        player2.reset();
    }

    
    }


    

