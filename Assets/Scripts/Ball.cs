using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
	void Start ()
    {
		
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
}
