using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera2 : MonoBehaviour
{
    public Camera cam1;
    public Camera cam2;
    public Camera cam3;


    // Start is called before the first frame update
    void Start()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            cam1.enabled = false;
            cam2.enabled = false;
            cam3.enabled = true;

        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
