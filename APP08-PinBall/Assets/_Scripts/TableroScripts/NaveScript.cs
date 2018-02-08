using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaveScript : MonoBehaviour {

    public GameObject explosion;
    private const int numGolpesNaveMax = 3;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Ball"))
        {
            GameManager.puntuacion += 2;
            GetComponent<AudioSource>().Play();
            GetComponent<Animation>().Play();
            GameManager.golpesNave++;

            if (GameManager.golpesNave == numGolpesNaveMax)
            {
                GameManager.puntuacion += 50;
                Instantiate(explosion, transform.position, Quaternion.identity);
                Destroy(gameObject);
                GameManager.nave = false;
            }
        }
    }
}
