using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InterfaceFinalLeapMotion : MonoBehaviour
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
        GameManager.fliperDerecho = false;
        GameManager.fliperIzquierdo = false;
        GameManager.fliperDerechoSonido = false;
        GameManager.fliperIzquierdoSonido = false;
        GameManager.space = false;
        GameManager.puntuacion = 0;
        GameManager.meteoritosDestruidos = 0;
        GameManager.meteoritosTotales = 26;
        GameManager.vidas = 3;
        GameManager.golpesNave = 0;
        GameManager.nave = true;
        GameManager.numPasoBola = 1;
        GameManager.fliperDerechoSuperiorSonido = false;
        GameManager.fliperDerechoSuperior = false;
        SceneManager.LoadScene("PinBallCustomLeapMotion");
    }

}