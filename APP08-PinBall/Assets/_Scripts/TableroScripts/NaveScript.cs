
///////////////////////////////
// Practica: Pin-Ball
// Alumno/a: Laura Calvente Domínguez
// Curso: 2017/2018
// Fichero: NaveScript.cs
///////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaveScript : MonoBehaviour {

    #region Variables
    [Header("Efecto explosión")]
    [Tooltip("Efecto cuando explota")]
    // Efecto de magia al rebotar
    public GameObject explosion;
    [Tooltip("Cuando llega a los 3 toques explota")]
    // golpes maximos para partirse la nave
    private const int numGolpesNaveMax = 3;
    #endregion

    #region Métodos
    /// <summary>
    /// Si la nave aun no ha llegado a los 3 toques se ejecuta la animación y puntua, 
    /// sino se destruye realizando un efecto.
    /// </summary>
    /// <param name="collision"></param>
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
    #endregion
}
