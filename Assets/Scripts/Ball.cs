using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody rb;
    private Vector3 velocity;

    void Start ()
    {
        rb = GetComponent<Rigidbody>();
        velocity = new Vector3(0, 0, 1f);
	}
	
	void Update ()
    {
		
	}

    void FixedUpdate()
    {
        if(Input.GetKeyDown(KeyCode.Space))
            rb.velocity = velocity;
    }

    public void RightArrow()
    {
        this.transform.Translate(new Vector3(+0.01f, 0, 0));
    }

    public void LeftArrow()
    {
        this.transform.Translate(new Vector3(-0.01f, 0, 0));
    }
}
