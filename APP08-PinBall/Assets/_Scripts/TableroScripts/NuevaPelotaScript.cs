
///////////////////////////////
// Practica: Pin-Ball
// Alumno/a: Laura Calvente Domínguez
// Curso: 2017/2018
// Fichero: NuevaPelotaScript.cs
///////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NuevaPelotaScript : MonoBehaviour {

    #region Variables
    [Header("Activación nueva vida o fin partida")]
    // Pundo donde vuelve a aparecer la pelota
    public GameObject puntoPelota;
    // Puerta que se debe animar cuando se gasta una nueva vida
    public GameObject door;
    #endregion

    #region Métodos
    /// <summary>
    /// Si es la pelota la que entra en el trigger se resta una vida si hay más de una
    /// y se activa la animación para abrir la puerta.
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
                SceneManager.LoadScene("Final");
            }
        }
    }
    #endregion
}
