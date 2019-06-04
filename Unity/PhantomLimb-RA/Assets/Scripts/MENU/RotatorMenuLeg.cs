using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatorMenuLeg : MonoBehaviour
{
    public float x,y,z;
    public GameObject auxLegRotator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        auxLegRotator.transform.Rotate(x, y, z, Space.Self);
    }
}
