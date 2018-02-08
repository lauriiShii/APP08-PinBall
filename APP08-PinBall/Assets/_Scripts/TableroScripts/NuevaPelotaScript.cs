using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NuevaPelotaScript : MonoBehaviour {

    public GameObject puntoPelota;
    public GameObject door;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            if (GameManager.vidas > 1)
            {
                other.gameObject.GetComponent<Transform>().position = puntoPelota.GetComponent<Transform>().position;
                GameManager.vidas--;
                door.GetComponent<Animation>().Play("CloseDoorBall");
            }
            else
            {
                SceneManager.LoadScene("Final");
            }
        }

    }
}
