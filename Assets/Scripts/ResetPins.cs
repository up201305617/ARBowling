using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPins : MonoBehaviour
{
    private Transform temp;
    private bool firstTime;
    public GameObject prefabPinSet;
    public GameObject oldPinSet;
    public Transform markerPosition;

    void Start()
    {
        firstTime = true;

        if (firstTime)
        {
            temp = oldPinSet.transform;
            firstTime = false;
        }
    }

    void Update()
    {

    }

    public void Restart()
    {
        Destroy(oldPinSet);
        oldPinSet = (GameObject)Instantiate(prefabPinSet, markerPosition.position, Quaternion.Euler(90, 0, 0));
        Check.pinsStanding = 0;
    }
}