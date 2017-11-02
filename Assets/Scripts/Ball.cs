﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody rb;
    private int launch;
    private Vector3 velocity;
    private Vector3 initialPosition;
    private Check check;
    public static int points;

    void Start ()
    {
        rb = GetComponent<Rigidbody>();
        initialPosition = transform.position;
        velocity = new Vector3(0, 0, 1f);
        check = FindObjectOfType<Check>();
        points = 0;
        launch = 2;
	}
	
	void Update ()
    {
		
	}

    public void RightArrow()
    {
        this.transform.Translate(new Vector3(+0.01f, 0, 0));
    }

    public void LeftArrow()
    {
        this.transform.Translate(new Vector3(-0.01f, 0, 0));
    }

    public void LaunchBall()
    {
        if(launch > 0)
        {
            velocity = velocity * check.power.value;
            rb.velocity = velocity;
        }
    }

    public void Next()
    {
        if(launch > 0)
        {
            launch--;
            Reset();
        }
    }

    public void Reset()
    {
        rb.velocity = Vector3.zero;
        velocity = new Vector3(0, 0, 1);
        transform.position = initialPosition;
        check.power.value = 0;
    }
}
