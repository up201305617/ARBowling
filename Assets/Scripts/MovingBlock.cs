using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBlock : MonoBehaviour
{
	void Start ()
    {
		
	}
	
	void Update ()
    {
        transform.position = new Vector3(Mathf.PingPong(Time.time/2, 0.4f)-0.1f, transform.position.y, transform.position.z);
    }
}
