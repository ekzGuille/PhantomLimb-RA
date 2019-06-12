using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LegController : MonoBehaviour
{
    public Animator anim;
    public GameObject leg;
    private float offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = 0;
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("1") && offset < 40)
        {
            //print("Has pulsado el 1");
            //anim.Play("flexion_rodilla", -1, 0f);
            offset++;
            leg.transform.Rotate(0, -2, 0);
        } else if (!Input.GetKey("1") && offset != 0)
        {
            offset--;
            leg.transform.Rotate(0, 2, 0);
        }
    }
}
