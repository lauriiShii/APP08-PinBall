using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IslaScript : MonoBehaviour {

    public GameObject fireWorksIsla;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Ball"))
        {
            GetComponent<AudioSource>().Play();
            Instantiate(fireWorksIsla, collision.gameObject.transform.position, Quaternion.identity);
        }
    }
}
