using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipperScript : MonoBehaviour {

    // Anguli de posicion de descanso
    public float restPosition = 0.0f;
    // Angulo de posicion presionado
    public float pressedPosition = 45.0f;
    // Fuerza del golpe de impacto
    public float hitStrength = 10000.0f;
    // Fuerza del flipper
    public float flipperDamper = 150.0f;
    // Nombre de la entrada
    public String inputName;

    HingeJoint hingeJoint;

    // Use this for initialization
    void Start()
    {
        hingeJoint = GetComponent<HingeJoint>();
        hingeJoint.useSpring = true;
    }

    // Update is called once per frame
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

}
