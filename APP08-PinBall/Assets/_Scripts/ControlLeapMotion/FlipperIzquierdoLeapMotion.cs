using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipperIzquierdoLeapMotion : MonoBehaviour {

    // Angulo de posicion en reposo
    public float restPosition = 0f;
    // Angulo de posicion presionado
    public float pressedPosition = 45f;
    // Fuerza del golpe de impacto
    public float hitStrength = 30000;
    // Fuerza del flipper
    public float flipperDamper = 10000f;
    // Nombre de la entrada
    public string inputName;

    HingeJoint hingeJoint;
    JointSpring spring;

    // Use this for initialization
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

    // Update is called once per frame
    void Update()
    {

        if (GameManager.fliperIzquierdo)
        {
            if (GameManager.fliperIzquierdoSonido)
            {
                // Controlamos que se haga la orden solo una vez
                GameManager.fliperIzquierdoSonido = false;
                // Reproducimos el sonido del flipper
                GetComponent<AudioSource>().PlayDelayed(Time.deltaTime);
            }
            spring.targetPosition = pressedPosition;
        }
        else
        {
            GameManager.fliperIzquierdoSonido = true;
            spring.targetPosition = restPosition;
        }

        hingeJoint.spring = spring;
        hingeJoint.useLimits = true;

        GameManager.fliperIzquierdo = false;

    }

    public void Action()
    {
        GameManager.fliperIzquierdo = true;
    }
}