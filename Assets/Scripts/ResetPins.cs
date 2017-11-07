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

    private Transform original1;
    private Transform original2;
    private Transform original3;
    private Transform original4;
    private Transform original5;
    private Transform original6;
    private Transform original7;
    private Transform original8;
    private Transform original9;
    private Transform original10;
    private Transform temp;
    private bool firstTime;
    public GameObject pinPrefab;
    public GameObject prefab;
    public GameObject old;
    public Transform marker;

    void Start()
    {
        firstTime = true;
        original1 = pin_1.transform;
        original2 = pin_2.transform;
        original3 = pin_3.transform;
        original4 = pin_4.transform;
        original5 = pin_5.transform;
        original6 = pin_6.transform;
        original7 = pin_7.transform;
        original8 = pin_8.transform;
        original9 = pin_9.transform;
        original10 = pin_10.transform;

        if (firstTime)
        {
            temp = old.transform;
            firstTime = false;
        }
    }

    void Update()
    {

    }

    public void Restart()
    {
        Destroy(old);
        old = (GameObject)Instantiate(prefab, marker.position, Quaternion.Euler(90, 0, 0));
        Check.pinsStanding = 0;
    }
}