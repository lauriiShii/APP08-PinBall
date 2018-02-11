
///////////////////////////////
// Practica: Pin-Ball
// Alumno/a: Laura Calvente Domínguez
// Curso: 2017/2018
// Fichero: FlipperDerechoLeapMotion.cs
///////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipperDerechoLeapMotion : MonoBehaviour
{
    #region Variables
    [Header("Diferentes posiciones del flipper")]
    // Angulo de posicion en reposo
    public float restPosition = 0f;
    // Angulo de posicion presionado
    public float pressedPosition = 45f;
    [Header("Fuerzas para el flipper")]
    [Tooltip("Fuerza con la que sube el flipper")]
    // Fuerza del golpe de impacto
    public float hitStrength = 30000;
    // Fuerza del flipper
    [Tooltip("Resistencia del flipper")]
    public float flipperDamper = 10000f;
    // Punto sobre el que gira el flipper
    HingeJoint hingeJoint;
    // Fuerza que intenta que el flipper vuelva a su 
    // posición original
    JointSpring spring;
    #endregion

    #region Métodos
    /// <summary>
    /// Instanciamos el "hingeJoint" y el "spring".
    /// </summary>
    void Start()
    {
        hingeJoint = GetComponent<HingeJoint>();
        hingeJoint.useSpring = true;

        spring = new JointSpring
        {
            spring = hitStrength,
            damper = flipperDamper
        };
    }

    /// <summary>
    /// Si el flipper esta levantado emitimos sonido solo una vez.
    /// Sino el sonido vuelve a estar disponible de usar y el 
    /// flipper vuelve a su posición natural, volviendo a ser utilizable.
    /// </summary>
    void Update()
    {

        if (GameManager.fliperDerecho)
        {
            if (GameManager.fliperDerechoSonido)
            {
                GameManager.fliperDerechoSonido = false;
                GetComponent<AudioSource>().PlayDelayed(Time.deltaTime);
            }
            spring.targetPosition = pressedPosition;
        }
        else
        {
            GameManager.fliperDerechoSonido = true;
            spring.targetPosition = restPosition;
        }

        hingeJoint.spring = spring;
        hingeJoint.useLimits = true;
        GameManager.fliperDerecho = false;

    }

    /// <summary>
    /// El script detecta que el flipper esta iniciando la acción de moverse.
    /// </summary>
    public void Action()
    {
        GameManager.fliperDerecho = true;
    }
    #endregion
}