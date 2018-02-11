
///////////////////////////////
// Practica: Pin-Ball
// Alumno/a: Laura Calvente Domínguez
// Curso: 2017/2018
// Fichero: NuevaPelotaScriptLeapMotion.cs
///////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NuevaPelotaScriptLeapMotion : MonoBehaviour {

    #region Variables
    [Header("Activación nueva vida o fin partida")]
    // Punto donde la pelota debe 
    public GameObject puntoPelota;
    // Puerta a animar
    public GameObject door;
    #endregion

    #region Métodos
    /// <summary>
    /// Si no quedan vidas hay que ir a la scena final, sino animamos la puerta de cierre.
    /// </summary>
    /// <param name="other"></param>
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
                SceneManager.LoadScene("FinalLeapMotion");
            }
        }

    }
    #endregion
}
