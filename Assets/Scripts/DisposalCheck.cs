using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisposalCheck : MonoBehaviour
{
    public Transform PinMarker;
    public Transform BallMarker;
    public Text distance;

    void Start ()
    {
        distance.text = "";
	}
	
	void Update ()
    {
        float dist = Vector3.Distance(PinMarker.position, BallMarker.position);
        distance.text = dist+"";
        //Debug.Log("Distance is:" + dist);
    }
}
