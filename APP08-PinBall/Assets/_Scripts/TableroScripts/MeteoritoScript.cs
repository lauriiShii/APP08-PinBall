using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteoritoScript : MonoBehaviour {

    public GameObject explosion;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Ball"))
        {
            GameManager.puntuacion += 5;
            Instantiate(explosion, transform.position, Quaternion.identity);
            GameManager.meteoritosDestruidos++;
            Destroy(gameObject);
        }
    }
}
