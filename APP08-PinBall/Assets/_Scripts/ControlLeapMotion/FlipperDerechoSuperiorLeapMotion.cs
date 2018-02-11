
///////////////////////////////
// Practica: Pin-Ball
// Alumno/a: Laura Calvente Domínguez
// Curso: 2017/2018
// Fichero: FlipperDerechoSuperiorLeapMotion.cs
///////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipperDerechoSuperiorLeapMotion : MonoBehaviour
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
    [Tooltip("Resistencia del flipper")]
    // Fuerza del flipper
    public float flipperDamper = 10000f;
    // Nombre de la entrada
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
        if (GameManager.fliperDerechoSuperior)
        {
            if (GameManager.fliperDerechoSuperiorSonido)
            {
                GameManager.fliperDerechoSonido = false;
                GetComponent<AudioSource>().PlayDelayed(Time.deltaTime);
            }
            spring.targetPosition = pressedPosition;
        }
        else
        {
            GameManager.fliperDerechoSuperiorSonido = true;
            spring.targetPosition = restPosition;
        }

        hingeJoint.spring = spring;
        hingeJoint.useLimits = true;
        GameManager.fliperDerechoSuperior = false;

    }

    /// <summary>
    /// El script detecta que el flipper esta iniciando la acción de moverse.
    /// </summary>
    public void Action()
    {
        GameManager.fliperDerechoSuperior = true;
    }
    #endregion
}