using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{
    private Rigidbody rb;
    private int launch;
    private int rounds;
    private Vector3 velocity;
    private Vector3 initialPosition;
    private Check check;
    public static int points;
    public GameObject restartGame;

    void Start ()
    {
        rb = GetComponent<Rigidbody>();
        initialPosition = transform.position;
        velocity = new Vector3(0, 0, 1f);
        check = FindObjectOfType<Check>();
        points = 0;
        launch = 2;
        rounds = 10;
	}

    void Points()
    {
        int tempPoints = 0;

        if (launch == 1)
        {
            tempPoints = 10 - Check.pinsStanding;
            points += (10 - Check.pinsStanding) * 2;
        }
        else
            points += tempPoints - Check.pinsStanding;
    }

	void Update ()
    {
        //Points();
	}

    public void RightArrow()
    {
        this.transform.Translate(new Vector3(+0.01f, 0, 0));
    }

    public void LeftArrow()
    {
        this.transform.Translate(new Vector3(-0.01f, 0, 0));
    }

    public void LaunchBall()
    {
        if(launch > 0)
        {
            velocity = velocity * check.power.value;
            rb.velocity = velocity;
        }
    }

    public void Next()
    {
        if(launch > 0)
        {
            launch--;
            Reset();
        }
        if(launch == 0)
        {
            rounds--;
            //NextRound();
            restartGame.GetComponent<ResetPins>().Restart();
        }
        if(rounds == 0)
        {
            SceneManager.LoadScene(3);
        }
    }

    public void Reset()
    {
        rb.velocity = Vector3.zero;
        velocity = new Vector3(0, 0, 1);
        transform.position = initialPosition;
        check.power.value = 0;
    }

    public void NextRound()
    {
        rb.velocity = Vector3.zero;
        velocity = new Vector3(0, 0, 1);
        transform.position = initialPosition;
        check.power.value = 0;
        launch = 2;
    }

    public int GetRounds()
    {
        return rounds;
    }
}
