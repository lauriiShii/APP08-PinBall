using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InterfaceGame : MonoBehaviour {

    public Text txtPuntuacion;
    public Text txtMeteoritosDestruidos;
    public Text txtVidas;
	
	// Update is called once per frame
	void Update () {
        txtPuntuacion.text = string.Format("Puntuación: {0}", GameManager.puntuacion);
        txtMeteoritosDestruidos.text = string.Format("Meteoritos destruidos: {0}", GameManager.meteoritosDestruidos);
        txtVidas.text = string.Format("Vidas restantes: {0}", GameManager.vidas);
    }
}
