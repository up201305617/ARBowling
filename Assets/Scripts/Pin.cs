using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pin : MonoBehaviour
{
    private Rigidbody rb;
    private Transform originalOrientation;
    private bool standing;
    public static int pinsStanding;
    public Transform groundCheck;

    void Start ()
    {
        Check.pinsStanding++;
        originalOrientation = transform;
        Debug.Log(originalOrientation);
        standing = true;
        rb=GetComponent<Rigidbody>();
	}
	
	void Update ()
    {
       if(!standing)
        {
            Destroy(gameObject, 5.0f);
        }
	}

    void OnTriggerExit(Collider other)
    {
        if(other.tag == "Ground")
        {
            Check.pinsStanding--;
            standing = false;
        }
    }

    public void Reset()
    {
        rb.velocity = Vector3.zero;
        Check.pinsStanding++;
        standing = true;
        transform.position = originalOrientation.position;
        transform.rotation = originalOrientation.rotation;
    }

    public bool GetStanding()
    {
        return standing;
    }
}
