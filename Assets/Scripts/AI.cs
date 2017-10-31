using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour
{
    private GameObject check;
    private Check checkScript;
    private Rigidbody rb;
    private Vector3 velocity;
    private Vector3 initialPosition;

    void Start ()
    {
        check = GameObject.FindGameObjectWithTag("Check");
        checkScript = check.GetComponent<Check>();
        transform.Rotate(new Vector3(90, 0, 0));
        rb = GetComponent<Rigidbody>();
        initialPosition = transform.position;
        velocity = new Vector3(0, 0, 1f);
    }
	
	void Update ()
    {
		
	}

    void FixedUpdate()
    {
        if(!checkScript.isPlayerTurn)
        {
            Vector3 fwd = transform.TransformDirection(Vector3.forward);
            RaycastHit[] hits = Physics.RaycastAll(transform.position, fwd, 20);
            Debug.DrawRay(transform.position , fwd, Color.green);
            for (int i = 0; i < hits.Length; i++)
            {
                if (hits[i].collider.tag == "Pin")
                {
                    velocity = velocity * 5;
                    rb.velocity = velocity;
                }
            }
        }
    }


}
