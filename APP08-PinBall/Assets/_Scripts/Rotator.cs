
///////////////////////////////
// Practica: Pin-Ball
// Alumno/a: Laura Calvente Domínguez
// Curso: 2017/2018
// Fichero: Rotator.cs
///////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {

    #region Variables
    [Header("Fuerzas para rotar")]
    // Fuera de  rotación que se aplica sobre el eje x del gameObject
    private float x;
    // Fuera de  rotación que se aplica sobre el eje y del gameObject
    private float y;
    // Fuera de  rotación que se aplica sobre el eje z del gameObject
    private float z;
    #endregion

    #region Métodos
    /// <summary>
    /// Instanciamos los valores de la fuerza que aplicaremos sobre el gameObject en todas las 
    /// perspectivas.
    /// </summary>
    void Start()
    {
        x =  Random.Range(0f, 90f);
        y = Random.Range(0f, 90f);
        z = Random.Range(0f, 90f);
    }

    /// <summary>
    /// Rotamos el gameObject con los valores decididos aleatoriamente al instanciar este.
    /// </summary>
    void Update () {
        transform.Rotate(new Vector3(x, y, z) * Time.deltaTime);
	}
    #endregion
}
