using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InterfaceFinal : MonoBehaviour
{

    public Text puntuacion;
    public Text meteoritos;
    public Text winOrGameOver;

    void Start()
    {
        puntuacion.text = string.Format("Puntuacion: {0}", GameManager.puntuacion.ToString());
        meteoritos.text = string.Format("MeteoritosDestruidos: {0}", GameManager.meteoritosDestruidos.ToString());
        if (GameManager.puntuacion <= 2000)
        {
            winOrGameOver.text = string.Format("GAME OVER");
        }
        else
        {
            winOrGameOver.text = string.Format("YOU WIN");
        }
    }

    public void OnClick()
    {
        GameManager.puntuacion = 0;
        GameManager.meteoritosDestruidos = 0;
        GameManager.vidas = 0;
        SceneManager.LoadScene("PinBallCustom");
    }

}