using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pin : MonoBehaviour
{
    public Transform originalOrientation;
    private bool standing;
    public static int pinsStanding;
    public Transform groundCheck;

    void Start ()
    {
        Check.pinsStanding++;
        originalOrientation = transform;
        standing = true;
	}
	
	void Update ()
    {
       if(!standing)
        {
            //Destroy(gameObject, 10f);
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
