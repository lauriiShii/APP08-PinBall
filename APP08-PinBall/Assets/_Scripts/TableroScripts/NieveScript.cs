
///////////////////////////////
// Practica: Pin-Ball
// Alumno/a: Laura Calvente Domínguez
// Curso: 2017/2018
// Fichero: NieveScript.cs
///////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NieveScript : MonoBehaviour {

    #region Variables
    [Header("Efecto magico")]
    // Efecto de magia al rebotar
    public GameObject fireWorksCapsule;
    #endregion

    #region Métodos
    /// <summary>
    /// Suena, se anima y puntua mostrando un efecto de magía.
    /// </summary>
    /// <param name="collision"></param>
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Ball"))
        {
            GameManager.puntuacion += 5;
            GetComponent<Animation>().Play();
            GetComponent<AudioSource>().Play();
            Instantiate(fireWorksCapsule, collision.gameObject.transform.position, Quaternion.identity);
        }
    }
    #endregion
}
