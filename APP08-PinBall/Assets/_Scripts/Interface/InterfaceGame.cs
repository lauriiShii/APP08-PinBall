
///////////////////////////////
// Practica: Pin-Ball
// Alumno/a: Laura Calvente Domínguez
// Curso: 2017/2018
// Fichero: InterfaceGame.cs
///////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InterfaceGame : MonoBehaviour {

    #region Variables
    [Header("Textos a mostrar")]
    // GameObject que muestra el contedio
    public Text txtPuntuacion;
    // Número de meteoritos destruidos
    public Text txtMeteoritosDestruidos;
    // Vidas restantes
    public Text txtVidas;
    #endregion

    #region Métodos
    /// <summary>
    /// Actualiza los textos de la interface
    /// </summary>
    void Update () {
        txtPuntuacion.text = string.Format("Puntuación: {0}", GameManager.puntuacion);
        txtMeteoritosDestruidos.text = string.Format("Meteoritos destruidos: {0}", GameManager.meteoritosDestruidos);
        txtVidas.text = string.Format("Vidas restantes: {0}", GameManager.vidas);
    }
    #endregion
}
