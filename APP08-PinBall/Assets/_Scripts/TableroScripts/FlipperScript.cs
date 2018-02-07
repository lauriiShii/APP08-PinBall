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

        if (Input.GetAxis(inputName) == 1)
        {
            spring.targetPosition = pressedPosition;
        }
        else
        {
            spring.targetPosition = restPosition;
        }

        hingeJoint.spring = spring;
        hingeJoint.useLimits = true;
            
    }

}
