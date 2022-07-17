using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int times = 0; 
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision other)
    {
        times ++;
        Debug.Log("You've bumped into barriers for: " + times);
    }
}
