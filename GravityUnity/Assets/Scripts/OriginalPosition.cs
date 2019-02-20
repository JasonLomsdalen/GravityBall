using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OriginalPosition : MonoBehaviour
{
    Vector3 startPos;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void resetBalls ()
    {
        rb = GetComponent<Rigidbody>();
        transform.position = startPos;
        if (rb)
        {
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }
    }
}
