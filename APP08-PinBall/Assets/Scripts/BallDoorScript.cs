using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDoorScript : MonoBehaviour {

    public GameObject door;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            // Se hace animacion para que la puerta impida subir a la pelota
            door.GetComponent<Animation>().Play();
        }

    }
}
