using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatePropeller : MonoBehaviour
{
    public float rotationSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       transform.transform.Rotate(0.0f, 0.0f, 10.0f, Space.Self);        
    }
}
