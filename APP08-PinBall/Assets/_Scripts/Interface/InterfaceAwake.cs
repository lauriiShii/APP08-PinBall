using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InterfaceAwake : MonoBehaviour {

    void Start()
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
    }

    public void Click()
    {
        SceneManager.LoadScene("PinBallCustom");
    }
}
