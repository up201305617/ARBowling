using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
    public Text pins;
    public Text rounds;
    public Slider power;
    public static int pinsStanding;
    public bool isPlayerTurn;
    public GameObject playerBall;
    public static bool canLaunch;
    public static bool proximity = false;

    void Start()
    {
        distance.text = "";
        twoMarkers.text = "";
        rounds.text = "";
        armarker = artoolkit.GetComponents<ARMarker>();
        GetMarkers();
        isPlayerTurn = false;
        playerBall.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }

        float dist = Vector3.Distance(PinMarker.position, BallMarker.position);

        if (dist<=0.20f)
        {
            distance.text = "Too close (>0.20f) - "+dist;
            proximity = false;
        }
        else
        {
            distance.text = "";
            proximity = true;
        }
        

        if (ballMarkerScript.Visible==true && pinMarkerScript.Visible==true)
        {
            twoMarkers.text = "";
            canLaunch = true;
        }
        else
        {
            twoMarkers.text = "The two marks have to be visible.";
            canLaunch = false;
        }

        if(pinsStanding >= 0)
        {
            //pins.text = pinsStanding + "";
        }

        rounds.text = "Round: "+playerBall.GetComponent<Ball>().GetRounds();
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