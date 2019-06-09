using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowController : MonoBehaviour
{
    public Animator anim;
    public GameObject bow, arrow;
    private float offset;
    public float speed = 0.2f;          //velocidad de tensado
    public const int MAX_WIDTH = 50;    //amplitud máxima de la cuerda

    private float strength = 1;         //fuerza que ejerce el paciente (recibido dsd el arduino)
    private bool ready;

    // Start is called before the first frame update
    void Start()
    {
        ready = true;
        offset = 0;
        anim = GetComponent<Animator>();

        //configurar señal arduino
    }

    // Update is called once per frame
    void Update()
    {
        //señal arduino
        if (ready)
        {
            Tensar();
        } else
        {
            ThrowArrow();
        }

       
    }

    public void ThrowArrow()
    {
        //1º Desvinculamos la flecha del arco
        arrow.transform.parent = null;

        //2º Aplicamos fuerza a la flecha
        Rigidbody rb = arrow.GetComponent<Rigidbody>();
        rb.constraints = RigidbodyConstraints.None;

        Vector3 v = new Vector3(0, 1, 0) * Time.deltaTime;
        rb.AddForce(v * 100);

        v = new Vector3(0, 0, 1) * Time.deltaTime;
        rb.AddForce(v * 15000);



        //esperar 2-3 segundos y reiniciar posicion arco y flecha
        StartCoroutine(ReiniciarTiro());
    }

    public void Tensar()
    {
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

        //Cuando llegue al MAX_WIDTH , evitar el tensado
        if (offset >= MAX_WIDTH)
        {
            ready = false;
        }
    }


    IEnumerator ReiniciarTiro()
    {
        // Reiniciamos cuerda
        bow.transform.Translate((speed * strength * offset), 0, 0);
        offset = 0;

        //print(Time.time);
        yield return new WaitForSeconds(3);

        //Crear nueva flecha en la posicion original

        //Todo listo
        ready = true;
        

        //print(Time.time);
    }
}
