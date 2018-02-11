
///////////////////////////////
// Practica: Pin-Ball
// Alumno/a: Laura Calvente Domínguez
// Curso: 2017/2018
// Fichero: PlungerLeapMotion.cs
///////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlungerLeapMotion : MonoBehaviour {

    #region Variables
    [Header("Energias del impacto contra la bola")]
    // Fuerza máxima con la que se podrá impulsar la bola.
    public float maxPower = 100f;
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
    /// Instanciamos la lista de bolas.
    /// </summary>
    void Start () {
        ballList = new List<Rigidbody>();
	}
	
	/// <summary>
    /// Si existe alguna bola reproduce el sonido para el lanzamiento y
    /// se aplica la fuerza. Luego los indicadores vuelven a sus valores predeterminados para poder 
    /// volver a usarlos.
    /// </summary>
	void Update () {

        if (ballList.Count > 0)
        {
            ballReady = true;
            if (GameManager.space)
            {
                foreach (Rigidbody r in ballList)
                {
                    GetComponent<AudioSource>().Play();
                    r.AddForce(maxPower * Vector3.forward);
                    GameManager.space = false;
                }
            }
        }
        else
        {
            ballReady = false;
            
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
    /// <summary>
    /// El script detecta que el espacio esta siendo pulsado con la mano.
    /// </summary>
    public void Action()
    {
        GameManager.space = true;
    }
    #endregion
}
