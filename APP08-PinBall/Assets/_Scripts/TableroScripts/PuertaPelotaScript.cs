
///////////////////////////////
// Practica: Pin-Ball
// Alumno/a: Laura Calvente Domínguez
// Curso: 2017/2018
// Fichero: PuertaPelota.cs
///////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuertaPelotaScript : MonoBehaviour {

    #region Variables
    [Header("Cerrar puerta")]
    // Puerta que se va a animar
    public GameObject door;
    #endregion

    #region Métodos
    /// <summary>
    /// La puerta se cierra.
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            // Se hace animacion para que la puerta impida subir a la pelota
            door.GetComponent<Animation>().Play("OpenDoorBall");
        }

    }
    #endregion
}
