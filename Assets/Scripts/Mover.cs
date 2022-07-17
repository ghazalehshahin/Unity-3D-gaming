using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 0.1f;
    //int score = 10;
    // Start is called before the first frame update
    void Start()
    {
        printToConsole();
    }

    // Update is called once per frame
    void Update()
    {
       moveThePlayer();
    }

    void printToConsole()
    {
        //Debug.Log("I am a new function");
    }
    
    void moveThePlayer()
    {
        float xVal = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zVal = Input.GetAxis ("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xVal, 0, zVal);
    }
}
