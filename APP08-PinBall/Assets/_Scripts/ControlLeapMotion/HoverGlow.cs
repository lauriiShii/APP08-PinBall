
///////////////////////////////
// Practica: Pin-Ball
// Alumno/a: Laura Calvente Domínguez
// Curso: 2017/2018
// Fichero: HoverGlow.cs
///////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap.Unity;
using Leap.Unity.Interaction;

// Se indica que es requerido que exista este componente
[RequireComponent(typeof(InteractionBehaviour))]
public class HoverGlow : MonoBehaviour
{
    #region Variables
    [Header("Activacion del Glow")]
    [Tooltip("Si esta activado, cambiara de color el objeto en funcion de la distancia de la mano")]
    // Indica si la mano esta por encima del botón
    public bool useHover = true;

    [Tooltip("Si esta activado, el objeto utilizara su primaryHoverControl cuando se acerque la mano")]
    // Se activa cuando se acerca la mano
    public bool usePrimaryHover = true;

    [Header("Colores")]
    // Hacemos una interpolacion lineal entre dos colores para conseguir el color intermedio:
    // - en este caso en concreto un gris muy oscuro
    public Color defaultColor = Color.Lerp(Color.black, Color.white, 0.1f);
    // - en este caso concreto un gris mas claro
    public Color hoverColor = Color.Lerp(Color.black, Color.white, 0.7f);
    // - en este caso concreto un gris muy claro
    public Color primaryHoverColor = Color.Lerp(Color.black, Color.white, 0.8f);

    // Suavidad del cambio de color
    public float smoothColor = 5f;

    // Referencia al material del objeto
    private Material material;
    // Referencia al script InteractionBehaviour
    private InteractionBehaviour intObj;
    #endregion

    #region Métodos
    /// <summary>
    /// Detecta el objeto más cercano a la mano. Obtenemos el material de ese
    /// gameObject.
    /// </summary>
    void Start()
    {
        // Recuperamos la referencial al componente InteractionBehaviour0
        intObj = GetComponent<InteractionBehaviour>();

        // Intentamos recuperar el componente renderer (a partir del renderer vamos a obtener el material del objeto) 
        Renderer renderer = GetComponent<Renderer>();

        // Si no existe el componente renderer en el objeto, lo buscamos en sus hijos
        if (renderer == null)
        {
            renderer = GetComponentInChildren<Renderer>();
        }

        // Si encontramos un renderer, recuperamos el material
        if (renderer != null)
        {
            material = renderer.material;
        }

    }

    /// <summary>
    /// Según la distancia de la mano al gameObject se pone un color u otro.
    /// </summary>
    void Update()
    {
        // Verificamos si existe la referencia al material
        if (material != null)
        {
            Color targetColor = defaultColor;

            // Si el evento detectado es primaryHover, el color objetivo sera el definido como primaryHoverColor
            if (intObj.isPrimaryHovered && usePrimaryHover)
            {
                targetColor = primaryHoverColor;
            }
            else
            {
                // Si el evento detectado es el hover, el color objetivo sera el definido como hoverColor
                if (intObj.isHovered && useHover)
                {
                    // Calculamos el glow en funcion de la distancia a la palma de la mano
                    // Convertimos con un map el valor de 0 a 0.2 de forma proporcional de 1 a 0
                    float glow = intObj.closestHoveringControllerDistance.Map(0f, 0.2f, 1f, 0.0f);

                    // Suavizamos el cambio de color en funcion del glow
                    targetColor = Color.Lerp(defaultColor, hoverColor, glow);
                }
            }

            // Interpolacion lineal del color inicial al color objetivo (Para que el cambio de color se haga suavemente)
            material.color = Color.Lerp(material.color, targetColor, smoothColor * Time.deltaTime);

        }
        #endregion
    }
}