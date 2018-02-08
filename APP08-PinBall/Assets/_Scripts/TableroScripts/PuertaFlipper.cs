using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuertaFlipper : MonoBehaviour {

    public GameObject door;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            if (GameManager.numPasoBola == 0)
            {
                // Se hace animacion para que la puerta impida subir a la pelota
                door.GetComponent<Animation>().Play();
            }
        }

        GameManager.numPasoBola--;

    }
}
