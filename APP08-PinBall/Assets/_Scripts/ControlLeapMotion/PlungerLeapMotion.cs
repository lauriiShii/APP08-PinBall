using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlungerLeapMotion : MonoBehaviour {

    public float maxPower = 100f;

    float power;
    List<Rigidbody> ballList;
    bool ballReady;

	// Use this for initialization
	void Start () {
        ballList = new List<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {

        if (ballList.Count > 0)
        {
            ballReady = true;
            if (GameManager.space)
            {
                foreach (Rigidbody r in ballList)
                {
                    GetComponent<AudioSource>().Play();
                    r.AddForce(maxPower * Vector3.forward);
                }
            }
        }
        else
        {
            ballReady = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            ballList.Add(other.gameObject.GetComponent<Rigidbody>());
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            ballList.Remove(other.gameObject.GetComponent<Rigidbody>());
            power = 0.0f;
        }
    }

    public void Action()
    {
        GameManager.space = true;
    }
}
