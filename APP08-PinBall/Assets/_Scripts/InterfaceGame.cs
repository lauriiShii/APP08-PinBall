using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InterfaceGame : MonoBehaviour {

    public Text txtPuntuacion;
    public Text txtMeteoritosDestruidos;
    public Text txtVidas;

	// Use this for initialization
	void Start () {

        GameManager.puntuacion = 0;
        GameManager.meteoritosDestruidos = 0;
        GameManager.meteoritosTotales = 20;
        GameManager.vidas = 3;
        GameManager.golpesNave = 0;
        GameManager.nave = true;
}
	
	// Update is called once per frame
	void Update () {
        txtPuntuacion.text = string.Format("Puntuación: {0}", GameManager.puntuacion);
        txtMeteoritosDestruidos.text = string.Format("Meteoritos destruidos: {0}", GameManager.meteoritosDestruidos);
        txtVidas.text = string.Format("Vidas restantes: {0}", GameManager.vidas);
    }
}
