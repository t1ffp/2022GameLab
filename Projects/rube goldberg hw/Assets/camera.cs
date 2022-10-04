using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class camera : MonoBehaviour
{

    public Camera cam1;
    public Camera cam2;
    public Camera cam3;

    // Start is called before the first frame update
    void Start()
    {
        cam1.enabled = true;
        cam2.enabled = false;
        cam3.enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            cam1.enabled = false;
            cam2.enabled = true;
            cam3.enabled = false;

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
            Debug.Log("Hello");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
