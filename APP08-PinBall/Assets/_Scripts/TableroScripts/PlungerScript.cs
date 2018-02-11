
///////////////////////////////
// Practica: Pin-Ball
// Alumno/a: Laura Calvente Domínguez
// Curso: 2017/2018
// Fichero: PlungerScript.cs
///////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlungerScript : MonoBehaviour {

    #region Variables
    [Header("Energias del impacto contra la bola")]
    // Fuerza máxima con la que se podrá impulsar la bola.
    public float maxPower = 100f;
    // Slider que muestra la fuerza con la que se realizará el lanzamiento
    public Slider powerSlider;
    // Fuerza con la que se impulsa la bola
    float power;
    [Header("Activacion de la bola")]
    [Tooltip("Lista de todas las bolas que se encuentran en el trigger")]
    // Array de bolas
    List<Rigidbody> ballList;
    [Tooltip("Si esta activo quiere decir que hay una bola que se puede lanzar")]
    // Dice si hay bola que lanzar
    bool ballReady;
    #endregion

    #region Métodos
    /// <summary>
    /// Instanciamos la lista de bolas y los sliders.
    /// </summary>
    void Start () {
        powerSlider.minValue = 0;
        powerSlider.maxValue = maxPower;
        ballList = new List<Rigidbody>();
	}

    /// <summary>
    /// Si existe alguna bola reproduce el sonido para el lanzamiento y
    /// se aplica la fuerza. Luego los indicadores vuelven a sus valores predeterminados para poder 
    /// volver a usarlos.
    /// </summary>
    void Update () {
        if (ballReady)
        {
            powerSlider.gameObject.SetActive(true);
        }
        else
        {
            powerSlider.gameObject.SetActive(false);
        }

        powerSlider.value = power;

        if (ballList.Count > 0)
        {
            ballReady = true;
            if (Input.GetKey(KeyCode.Space))
            {
                if (power < maxPower)
                {
                    power += 50 * Time.deltaTime;
                }
            }

            if (Input.GetKeyUp(KeyCode.Space))
            {
                foreach (Rigidbody r in ballList)
                {
                    GetComponent<AudioSource>().Play();
                    r.AddForce(power * Vector3.forward);
                }
            }
        }
        else
        {
            ballReady = false;
            power = 0.0f;
        }
    }

    /// <summary>
    /// Cuando la bola colisiona con este se añada al array.
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            ballList.Add(other.gameObject.GetComponent<Rigidbody>());
        }
    }

    /// <summary>
    /// Cuando la bola sale de la colision se elimina de la lista.
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            ballList.Remove(other.gameObject.GetComponent<Rigidbody>());
            power = 0.0f;
        }
    }
    #endregion
}
