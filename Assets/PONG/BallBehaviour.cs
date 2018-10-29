using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour {

    Rigidbody2D myRigidbody;

    public float maxSpeed;
    public float resetTime;
    Vector2 velocity;
    Vector2 position;
    bool frozen;

    float lastReset;
	// Use this for initialization
	void Start () {
        myRigidbody = gameObject.GetComponent<Rigidbody2D>();
        velocity = new Vector2(Random.Range(-6, -7), Random.Range(-3, 3));
        myRigidbody.velocity = velocity;
	}
	
	// Update is called once per frame
	void Update () {
        if(Time.time - lastReset > resetTime && frozen)
        {
            Debug.Log("unfreezing");
            frozen = false;
                myRigidbody.constraints = RigidbodyConstraints2D.None;
                myRigidbody.velocity = new Vector2(Random.Range(-7, 7), Random.Range(-7, 7));
        }

     

        Vector2 vel = gameObject.GetComponent<Rigidbody2D>().velocity;
        if (vel.sqrMagnitude > Mathf.Pow(maxSpeed, 2))
        {
            vel.Normalize();
            vel *= maxSpeed;
            gameObject.GetComponent<Rigidbody2D>().velocity = vel;
        }
    }

    public void reset()
    {
        myRigidbody.position = new Vector2(0,0);
        lastReset = Time.time;
        frozen = true;
        myRigidbody.constraints = RigidbodyConstraints2D.FreezeAll;
    }
}
