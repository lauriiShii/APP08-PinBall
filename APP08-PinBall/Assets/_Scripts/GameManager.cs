
///////////////////////////////
// Practica: Pin-Ball
// Alumno/a: Laura Calvente Domínguez
// Curso: 2017/2018
// Fichero: GameManager.cs
///////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager {

    #region Variables
    [Header("Indicadores de uso de los flippes")]
    // Indica si el flipper izquierdo esta levantado o no
    public static bool fliperIzquierdo;
    // Indica si el flipper derecho esta levantado o no
    public static bool fliperDerecho;
    // Indica si el flipper izquierdo esta emitiendo sonido
    public static bool fliperIzquierdoSonido;
    // Indica si el flipper derecho esta emitiendo sonido
    public static bool fliperDerechoSonido;
    // Indica si el flipper derecho superior esta emitiendo sonido
    public static bool fliperDerechoSuperiorSonido;
    // Indica si el flipper derecho superior esta levantado o no
    public static bool fliperDerechoSuperior;
    [Header("Otros indicadores")]
    [Tooltip("Indica si el boton espacio ha sido pulsado o no")]
    // Indica si el boton spacio de la integración con leapMotion esta
    // aún pulsado
    public static bool space;
    [Tooltip("Indica si la nae ha sido destruida o no")]
    // Indica si la nave ha sido destruida o no
    public static bool nave;
    [Tooltip("Indica la puntuación del jugador")]
    // Suma de todos los puntos que el usuario genera 
    // haciendo que la bola de golpes con los objetos
    public static int puntuacion;
    [Tooltip("Indica cuantos meteoritos ha destruido")]
    // Cantidad de meteoritos destruidos por el jugador
    public static int meteoritosDestruidos;
    [Tooltip("Indica los meteoritos totales que hay")]
    // Meteoritos totales que hay en el juego
    public static int meteoritosTotales;
    [Tooltip("Indica las vidas restantes")]
    // Vidas restantes del jugador
    public static int vidas;
    [Tooltip("Golpes que ha recivido la nave")]
    // La nave tiene un número limitado de golpes que 
    // puede recibir, cuando los supera se destruye
    public static int golpesNave;
    [Tooltip("Cuantas pelotas han usado el pungger izquierdo")]
    // Limite de veces que se puede utilizar el pungger izquierdo
    public static int numPasoBola;
    #endregion
}
