using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatorPropeller : MonoBehaviour
{
    public float spinSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // move the plane forward at a constant rate
        transform.Rotate(spinSpeed * Time.deltaTime * Vector3.forward);
    }
}
