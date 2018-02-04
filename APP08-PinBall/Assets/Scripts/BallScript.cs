using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public GameObject fireWorks;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Capsule"))
        {
            collision.gameObject.GetComponent<Animation>().Play();
            collision.gameObject.GetComponent<AudioSource>().Play();
            Instantiate(fireWorks, collision.gameObject.transform.position, Quaternion.identity);
        }
    }
}
