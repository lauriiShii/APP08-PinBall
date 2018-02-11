
///////////////////////////////
// Practica: Pin-Ball
// Alumno/a: Laura Calvente Domínguez
// Curso: 2017/2018
// Fichero: InterfaceInicio.cs
///////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InterfaceInicio : MonoBehaviour {

    #region Métodos
    /// <summary>
    /// Inicia la interfaz primaria
    /// </summary>
    public void Click()
    {
        SceneManager.LoadScene("Awake");
    }
    #endregion
}
