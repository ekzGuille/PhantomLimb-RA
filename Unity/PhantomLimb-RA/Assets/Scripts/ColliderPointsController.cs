using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderPointsController : MonoBehaviour

{
    public GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
        obj.GetComponent<MeshRenderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
