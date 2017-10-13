using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Check : MonoBehaviour
{
    private ARMarker [] armarker;
    private ARMarker ballMarkerScript;
    private ARMarker pinMarkerScript;
    public Transform artoolkit;
    public Transform PinMarker;
    public Transform BallMarker;
    public Text distance;
    public Text twoMarkers;
    public Text position;

    void Start()
    {
        distance.text = "";
        twoMarkers.text = "";
        position.text = "";
        armarker = artoolkit.GetComponents<ARMarker>();
        GetMarkers();
    }

    void Update()
    {
        float dist = Vector3.Distance(PinMarker.position, BallMarker.position);
        distance.text = dist + "";

        if (ballMarkerScript.Visible==true && pinMarkerScript.Visible==true)
        {
            twoMarkers.text = "";
        }
        else
        {
            twoMarkers.text = "The two marks have to be visible.";
        }
    }

    private void GetMarkers()
    {
        for(int i =0; i<armarker.Length;i++)
        {
            if(armarker[i].Tag == "hiro")
            {
                ballMarkerScript = armarker[i];
            }

            if(armarker[i].Tag == "kanji")
            {
                pinMarkerScript = armarker[i];
            }
        }
    }
}