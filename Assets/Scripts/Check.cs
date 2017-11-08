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
    public Text position;
    public Text pins;
    public Text rounds;
    public Slider power;
    public static int pinsStanding;
    public bool isPlayerTurn;
    public GameObject playerBall;
    public GameObject aiBall;
    public bool isTwo;

    void Start()
    {
        distance.text = "";
        twoMarkers.text = "";
        position.text = "";
        pins.text = "";
        rounds.text = "";
        armarker = artoolkit.GetComponents<ARMarker>();
        GetMarkers();
        isPlayerTurn = false;
        playerBall.SetActive(false);
        //aiBall.SetActive(true);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }

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

        if(pinsStanding >= 0)
        {
            pins.text = pinsStanding + "";
        }
        //pins.text = Ball.points+"";

        //position.text = power.value + "";

        if (isTwo)
        {
            if (isPlayerTurn)
            {
                playerBall.SetActive(true);
                aiBall.SetActive(false);
            }
            else
            {
                playerBall.SetActive(false);
                aiBall.SetActive(true);
            }
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