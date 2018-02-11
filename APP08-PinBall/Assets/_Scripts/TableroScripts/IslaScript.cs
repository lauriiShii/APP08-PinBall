
///////////////////////////////
// Practica: Pin-Ball
// Alumno/a: Laura Calvente Domínguez
// Curso: 2017/2018
// Fichero: IslaScript.cs
///////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IslaScript : MonoBehaviour {

    #region Variables
    [Header("Efecto magico")]
    // Efecto de magia al rebotar
    public GameObject fireWorksIsla;
    #endregion

    #region Métodos
    /// <summary>
    /// Instancia la explosion de magia cuando rebota con este componente.
    /// </summary>
    /// <param name="collision"></param>
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Ball"))
        {
            GetComponent<AudioSource>().Play();
            Instantiate(fireWorksIsla, collision.gameObject.transform.position, Quaternion.identity);
        }
    }
    #endregion
}
