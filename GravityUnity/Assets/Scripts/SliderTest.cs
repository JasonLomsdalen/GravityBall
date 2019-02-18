using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SliderTest : MonoBehaviour
{
    
    // Update is called once per frame
    void UpdateGrav(float multiplier)
    {
        Vector3 oldGrav = Physics.gravity;
        Physics.gravity = new Vector3(0.0f, oldGrav.y * multiplier, 0.0f);
    }
}
