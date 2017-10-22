using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pin : MonoBehaviour
{
    private Transform originalOrientation;
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
        Debug.Log(transform.up+" "+transform.name);
        if (transform.up.y > 0.5f || transform.up.y <-0.5f)
        {
            //Check.pinsStanding--;
        }
        /*if (transform.eulerAngles.x >310 || transform.eulerAngles.x<230 )//|| transform.eulerAngles.y>210 || transform.eulerAngles.y<170)
        {
            Check.pinsStanding--;
            //Destroy(gameObject, 10f);
        }*/
	}

   /* void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ground")
        {
            if(Check.pinsStanding<10)
            Check.pinsStanding++;
        }
    }*/

    void OnTriggerExit(Collider other)
    {
        if(other.tag == "Ground")
        {
            Check.pinsStanding--;
        }
    }
}
