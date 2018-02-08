
///////////////////////////////
// Practica: Roll-a-ball
// Alumno/a: Laura Calvente Domínguez
// Curso: 2017/2018
// Fichero: Rotator.cs
///////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {

    private float x;
    private float y;
    private float z;

    #region Métodos
    void Start()
    {
        x =  Random.Range(0f, 90f);
        y = Random.Range(0f, 90f);
        z = Random.Range(0f, 90f);
    }

    void Update () {
        transform.Rotate(new Vector3(x, y, z) * Time.deltaTime);
	}
    #endregion
}
