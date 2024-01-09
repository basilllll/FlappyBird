using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMainMenuScript : MonoBehaviour
{
    public float power;
    public Rigidbody2D myRigidbody2d;
    public float JumpRate;
    public float timer;

    void Update()
    {
        if (timer < JumpRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            BirdFlap();
            timer = 0;
        }
    }


    public void BirdFlap()
    {
        myRigidbody2d.velocity = Vector2.up * power;
    }
}