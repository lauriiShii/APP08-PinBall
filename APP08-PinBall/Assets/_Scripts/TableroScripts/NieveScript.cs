using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NieveScript : MonoBehaviour {

    public GameObject fireWorksCapsule;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Ball"))
        {
            GameManager.puntuacion += 5;
            GetComponent<Animation>().Play();
            GetComponent<AudioSource>().Play();
            Instantiate(fireWorksCapsule, collision.gameObject.transform.position, Quaternion.identity);
        }
    }
}
