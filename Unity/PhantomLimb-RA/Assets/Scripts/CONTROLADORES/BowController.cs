using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowController : MonoBehaviour
{
    public Animator anim;
    public GameObject bow;
    private float offset;
    public float speed = 0.2f;          //velocidad de tensado
    public const int MAX_WIDTH = 50;    //amplitud máxima de la cuerda

    private float strength = 1;         //fuerza que ejerce el paciente (recibido dsd el arduino)

    // Start is called before the first frame update
    void Start()
    {
        offset = 0;
        anim = GetComponent<Animator>();

        //configurar señal arduino
    }

    // Update is called once per frame
    void Update()
    {
        //señal arduino

        if (Input.GetKey("1") && offset < MAX_WIDTH)
        {
            offset++;
            bow.transform.Translate(-speed * strength, 0, 0);
        }
        else if (!Input.GetKey("1") && offset != 0)
        {
            offset--;
            bow.transform.Translate(speed * strength, 0, 0);
        }

        //Cuando llegue al MAX_WIDTH , ejecutar lanzamiento
    }

    public void throwArrow()
    {

    }
}
