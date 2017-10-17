using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pin : MonoBehaviour
{
    private Transform originalOrientation;
    public static int pinsStanding;

    void Start ()
    {
        pinsStanding+=1;
        originalOrientation = transform;
	}
	
	void Update ()
    {
	    if(transform.eulerAngles.x >200 || transform.eulerAngles.x<160 || transform.eulerAngles.y>25 || transform.eulerAngles.y<-25)
        {
            pinsStanding--;
        }
	}
}
