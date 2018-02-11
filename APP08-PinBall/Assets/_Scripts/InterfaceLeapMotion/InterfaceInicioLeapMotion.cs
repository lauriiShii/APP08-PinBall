
///////////////////////////////
// Practica: Pin-Ball
// Alumno/a: Laura Calvente Domínguez
// Curso: 2017/2018
// Fichero: InterfaceInicioLeapMotion.cs
///////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InterfaceInicioLeapMotion : MonoBehaviour {

    #region Métodos
    /// <summary>
    /// Instancia la scena.
    /// </summary>
    public void Click()
    {
        SceneManager.LoadScene("AwakeLeapMotion");
    }
    #endregion
}
