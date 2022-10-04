using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stopper : MonoBehaviour
{
    public GameObject square;


    public Stopper()
    {
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            square.SetActive(true);
        else if (Input.GetKeyUp(KeyCode.Space))
            square.SetActive(false);
    }

}
