
///////////////////////////////
// Practica: Pin-Ball
// Alumno/a: Laura Calvente Domínguez
// Curso: 2017/2018
// Fichero: PuertaFlipper.cs
///////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuertaFlipper : MonoBehaviour {

    #region Variables
    [Header("Cerrar puerta")]
    // Puerta que se va a animar
    public GameObject door;
    #endregion

    #region Métodos
    /// <summary>
    /// Si no hay más intentos para lanzar la pelota se cierra la puerta.
    /// Sino se resta un intento.
    /// </summary>
    /// <param name="other"></param>
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
    #endregion
}
