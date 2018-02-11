
///////////////////////////////
// Practica: Pin-Ball
// Alumno/a: Laura Calvente Domínguez
// Curso: 2017/2018
// Fichero: ButtonManager.cs
///////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    #region Variables
    // Referencia al componente AudioSource
    private AudioSource audioSource;
    #endregion

    #region Métodos
    /// <summary>
    /// Instanciamos el componente de audio para poder reproducir el
    /// sonido en "Click();".
    /// </summary>
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    /// <summary>
    /// Se reproduce el sonido que recibe la clase a través de la
    /// variable "audioSource"
    /// </summary>
    public void Click()
    {
        audioSource.Play();
    }
    #endregion
}