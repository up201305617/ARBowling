using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPins : MonoBehaviour
{
    public GameObject pin_1;
    public GameObject pin_2;
    public GameObject pin_3;
    public GameObject pin_4;
    public GameObject pin_5;
    public GameObject pin_6;
    public GameObject pin_7;
    public GameObject pin_8;
    public GameObject pin_9;
    public GameObject pin_10;

    void Start()
    {

    }

    void Update()
    {

    }

    public void Reset()
    {
        if(!pin_1.GetComponent<Pin>().GetStanding())
            pin_1.GetComponent<Pin>().Reset();
        if (!pin_2.GetComponent<Pin>().GetStanding())
            pin_2.GetComponent<Pin>().Reset();
        if (!pin_3.GetComponent<Pin>().GetStanding())
            pin_3.GetComponent<Pin>().Reset();
        if (!pin_4.GetComponent<Pin>().GetStanding())
            pin_4.GetComponent<Pin>().Reset();
        if (!pin_5.GetComponent<Pin>().GetStanding())
            pin_5.GetComponent<Pin>().Reset();
        if (!pin_6.GetComponent<Pin>().GetStanding())
            pin_6.GetComponent<Pin>().Reset();
        if (!pin_7.GetComponent<Pin>().GetStanding())
            pin_7.GetComponent<Pin>().Reset();
        if (!pin_8.GetComponent<Pin>().GetStanding())
            pin_8.GetComponent<Pin>().Reset();
        if (!pin_9.GetComponent<Pin>().GetStanding())
            pin_9.GetComponent<Pin>().Reset();
        if (!pin_10.GetComponent<Pin>().GetStanding())
            pin_10.GetComponent<Pin>().Reset();
    }
}