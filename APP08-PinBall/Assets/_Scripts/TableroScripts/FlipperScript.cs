
///////////////////////////////
// Practica: Pin-Ball
// Alumno/a: Laura Calvente Domínguez
// Curso: 2017/2018
// Fichero: FlipperScript.cs
///////////////////////////////

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipperScript : MonoBehaviour {

    #region Variables
    [Header("Diferentes posiciones del flipper")]
    // Angulo de posicion de descanso
    public float restPosition = 0.0f;
    // Angulo de posicion presionado
    public float pressedPosition = 45.0f;
    [Header("Fuerzas para el flipper")]
    [Tooltip("Fuerza con la que sube el flipper")]
    // Fuerza del golpe de impacto
    public float hitStrength = 10000.0f;
    // Fuerza del flipper
    [Tooltip("Resistencia del flipper")]
    public float flipperDamper = 150.0f;
    // Nombre de la entrada
    [Header("Tecla pulsada")]
    public String inputName;
    // Punto sobre el que gira el flipper
    HingeJoint hingeJoint;
    #endregion

    #region Métodos
    /// <summary>
    /// Instanciamos el "hingeJoint" y el "spring".
    /// </summary>
    void Start()
    {
        hingeJoint = GetComponent<HingeJoint>();
        hingeJoint.useSpring = true;
    }

    /// <summary>
    /// Comprueba si el flipper esta en accion o no, si no lo esta lo hace.
    /// </summary>
    void Update()
    {
        JointSpring spring = new JointSpring();
        spring.spring = hitStrength;
        spring.damper = flipperDamper;
        sonido();
        if (Input.GetAxis(inputName) == 1)
        {
            spring.targetPosition = pressedPosition;
        }
        else
        {
            spring.targetPosition = restPosition;
            GameManager.fliperDerecho = true;
            GameManager.fliperIzquierdo = true;
        }

        hingeJoint.spring = spring;
        hingeJoint.useLimits = true;
            
    }

    /// <summary>
    /// Reproduce el sinido controlando que tecla se ha pulsado.
    /// </summary>
    private void sonido()
    {
        if (Input.GetKeyUp(KeyCode.D))
        {
            if (GameManager.fliperDerecho)
            {
                GameManager.fliperDerecho = false;
                GetComponent<AudioSource>().Play();
            }
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            if (GameManager.fliperIzquierdo)
            {
                GameManager.fliperIzquierdo = false;
                GetComponent<AudioSource>().Play();
            }
        }
    }
    #endregion

}
