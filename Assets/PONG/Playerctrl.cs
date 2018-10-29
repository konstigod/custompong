using UnityEngine;
using System.Collections;

public class Playerctrl: MonoBehaviour
{


    public KeyCode moveUp;
    public KeyCode moveDown;
    public KeyCode moveLeft;
    public KeyCode moveRight;
    public KeyCode dashKey;

    public int index;

    public Vector2 startingPosition;

    Rigidbody2D myRigidbody;

    public float speed;
    public float dashSpeed;

    public float maxDashPower = 99;
    float dashPower;

    private void Start()
    {
        myRigidbody = gameObject.GetComponent<Rigidbody2D>();
        myRigidbody.freezeRotation = true;
        reset();
        dashPower = 0;
    }

    void Update()
    {
        Vector2 vel = new Vector2(0, 0);
        if (Input.GetKey(moveUp))
        {
            vel[1] = speed;
        }
        if (Input.GetKey(moveDown))
        {
            vel[1] = -speed;
        }
        if (Input.GetKey(moveLeft))
        {
            vel[0] = -speed;
        }
        if (Input.GetKey(moveRight))
        {
            vel[0] = speed;
        }
        if (Input.GetKey(dashKey))
        {
            if(dashPower > 0)
            {
                vel.Normalize();
                vel *= dashSpeed;
                dashPower -= 3;
            }
        }
        if(index == 0 && myRigidbody.position[0] > -1)
        {
            if(vel[0] > 0)
            {
                vel[0] = 0;
            }
        }
        if (index == 1 && myRigidbody.position[0] < 1)
        {
            if (vel[0] < 0)
            {
                vel[0] = 0;
            }
        }
        dashPower += 1;
        myRigidbody.velocity = vel;
    }

    public void reset()
    {
        myRigidbody.position = startingPosition;
    }
}