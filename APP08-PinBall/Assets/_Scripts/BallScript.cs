using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public GameObject fireWorksCapsule;
    public GameObject fireWorksIsla;

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
            Instantiate(fireWorksCapsule, collision.gameObject.transform.position, Quaternion.identity);
        }
        if (collision.gameObject.tag.Equals("WallInternalIsla"))
        {
            collision.gameObject.GetComponent<AudioSource>().Play();
            Instantiate(fireWorksIsla, collision.gameObject.transform.position, Quaternion.identity);
        }
        if (collision.gameObject.tag.Equals("Nave"))
        {
            collision.gameObject.GetComponent<AudioSource>().Play();
            collision.gameObject.GetComponent<Animation>().Play();
        }
    }
}
