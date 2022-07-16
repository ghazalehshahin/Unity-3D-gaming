using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xVal = Input.GetAxis("Horizontal");
        float zVal = Input.GetAxis ("Vertical");
        transform.Translate(xVal, 0, zVal);
    }
}
