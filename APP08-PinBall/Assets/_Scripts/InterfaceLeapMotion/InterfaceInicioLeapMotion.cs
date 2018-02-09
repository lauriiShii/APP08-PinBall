using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InterfaceInicioLeapMotion : MonoBehaviour {

    public void Click()
    {
        SceneManager.LoadScene("AwakeLeapMotion");
    }
}
