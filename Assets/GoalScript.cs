using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalScript : MonoBehaviour
{


    GameBehaviour beh;
    GameObject ball;
    public int index;
    // Use this for initialization
    void Start()
    {
        beh = gameObject.GetComponentInParent<GameBehaviour>();
        ball = GameObject.Find("Ball");
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)


    {
        if (collision.gameObject == ball)
        {
            beh.goalScored(index);
        }
        }
    }

