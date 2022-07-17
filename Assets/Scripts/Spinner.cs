using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float xVal = 0.5f;
    [SerializeField] float yVal = 0.5f;
    [SerializeField] float zVal = 0.5f;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xVal,yVal,zVal);
    }
}
