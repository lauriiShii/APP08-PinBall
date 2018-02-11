
///////////////////////////////
// Practica: Pin-Ball
// Alumno/a: Laura Calvente Domínguez
// Curso: 2017/2018
// Fichero: InterfaceAwake.cs
///////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InterfaceAwake : MonoBehaviour {

    #region Métodos
    /// <summary>
    /// Inicializamos todas las variables del GameManager.
    /// </summary>
    void Start()
    {
        GameManager.fliperDerecho = false;
        GameManager.fliperIzquierdo = false;
        GameManager.fliperDerechoSonido = false;
        GameManager.fliperIzquierdoSonido = false;
        GameManager.space = false;
        GameManager.puntuacion = 0;
        GameManager.meteoritosDestruidos = 0;
        GameManager.meteoritosTotales = 26;
        GameManager.vidas = 3;
        GameManager.golpesNave = 0;
        GameManager.nave = true;
        GameManager.numPasoBola = 1;
        GameManager.fliperDerechoSuperiorSonido = false;
        GameManager.fliperDerechoSuperior = false;
}

    /// <summary>
    /// La interfaz es la encargada de gestionar el cambio de scena.
    /// </summary>
    public void Click()
    {
        SceneManager.LoadScene("PinBallCustom");
    }
    #endregion
}
