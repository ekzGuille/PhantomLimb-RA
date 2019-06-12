using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("flecha"))
        {
            Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();
            rb.constraints = RigidbodyConstraints.FreezeAll;
            collision.gameObject.GetComponent<Transform>().SetParent(gameObject.GetComponent<Transform>());
            //Destroy(gameObject);
        }
    }
}
