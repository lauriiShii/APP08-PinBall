
///////////////////////////////
// Practica: Pin-Ball
// Alumno/a: Laura Calvente Domínguez
// Curso: 2017/2018
// Fichero: MeteoritoScript.cs
///////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteoritoScript : MonoBehaviour {

    #region Variables
    [Header("Efecto magico")]
    // Efecto de magia al rebotar
    public GameObject explosion;
    #endregion

    #region Métodos
    /// <summary>
    /// Instancia la explosion de magia cuando rebota con este componente.
    /// Suma los puntos y destruye el meteorito.
    /// </summary>
    /// <param name="collision"></param>
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
    #endregion
}
