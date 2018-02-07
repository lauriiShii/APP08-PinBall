using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NuevaPelotaScript : MonoBehaviour {

    public GameObject puntoPelota;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            if (GameManager.vidas > 0)
            {
                other.gameObject.GetComponent<Transform>().position = puntoPelota.GetComponent<Transform>().position;
                GameManager.vidas--;
            }
        }

    }
}
