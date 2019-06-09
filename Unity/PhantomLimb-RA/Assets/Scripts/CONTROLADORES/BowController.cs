using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowController : MonoBehaviour
{
    public Animator anim;
    public GameObject bow, arrow;
    private GameObject originalArrow;
    private float offset;
    public float strengthBowVertical, strengthBowHorizontal;        //fuerza de la flecha
    public float sensibility = 0.2f;          //velocidad de tensado
    public const int MAX_WIDTH = 50;    //amplitud máxima de la cuerda

    private float strength = 1;         //fuerza que ejerce el paciente (recibido dsd el arduino)
    private int estadoJugador = 0;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;

        //Configuramos una flecha para clonar las siguientes y la ocultamos
        originalArrow = ClonarFlecha(arrow);
        originalArrow.name = "originalArrow";
        originalArrow.SetActive(false);

        //offset del arco
        offset = 0;
        
        anim = GetComponent<Animator>();

        //configurar señal arduino
    }

    // Update is called once per frame
    void Update()
    {
        //señal arduino
        if (estadoJugador == 0)
        {
            Tensar();
        } else if(estadoJugador == 1)
        {
            Disparar();
        }

       
    }

    public void Disparar()
    {
        //1º Desvinculamos la flecha del arco
        arrow.transform.parent = null;

        //2º Aplicamos fuerza a la flecha
        Rigidbody rb = arrow.GetComponent<Rigidbody>();
        rb.constraints = RigidbodyConstraints.None;

        Vector3 v = new Vector3(0, 1, 0) * Time.deltaTime * 10000;
        rb.AddForce(v * strengthBowVertical);

        v = new Vector3(0, 0, 1) * Time.deltaTime * 10000;
        rb.AddForce(v * strengthBowHorizontal);

        //Dispersión
        v = new Vector3(Random.Range(-50, 50), Random.Range(0, 10.0f), Random.Range(-50, 50)) * Time.deltaTime * 400;
        rb.AddForce(v);


        //esperar 2-3 segundos y reiniciar posicion arco y flecha
        estadoJugador = 2;
        StartCoroutine(Recargar());
        StartCoroutine(DestruirFlecha(arrow));
    }

    public void Tensar()
    {
        if (Input.GetKey("1") && offset < MAX_WIDTH)
        {
            offset++;
            bow.transform.Translate(-sensibility * strength, 0, 0);
        }
        else if (!Input.GetKey("1") && offset != 0)
        {
            offset--;
            bow.transform.Translate(sensibility * strength, 0, 0);
        }

        //Cuando llegue al MAX_WIDTH , evitar el tensado
        if (offset >= MAX_WIDTH)
        {
            estadoJugador = 1;
        }
    }


    IEnumerator Recargar()
    {
        
        // Reiniciamos cuerda
        bow.transform.Translate((sensibility * strength * offset), 0, 0);
        offset = 0;
        
        yield return new WaitForSeconds(3);
        //Crear nueva flecha en la posicion original
        arrow = ClonarFlecha(originalArrow);
        arrow.SetActive(true);
        //Todo listo
        estadoJugador = 0;
    }

    IEnumerator DestruirFlecha(GameObject flecha)
    {
        yield return new WaitForSeconds(15);
        Destroy(flecha);
    }

    private GameObject ClonarFlecha(GameObject flechaOriginal)
    {
        GameObject nuevaFlecha;
        //Clonamos el objeto
        nuevaFlecha = Instantiate(arrow);
        nuevaFlecha.name = "Flecha";
        nuevaFlecha.tag = "flecha";
        //Congelamos una de las coordenadas para que no se caiga al vacío
        Rigidbody rb = nuevaFlecha.GetComponent<Rigidbody>();
        rb.constraints = RigidbodyConstraints.FreezePositionY;

        //Posicionamos la nueva flecha donde está la original
        nuevaFlecha.GetComponent<Transform>().SetPositionAndRotation(flechaOriginal.GetComponent<Transform>().position, flechaOriginal.GetComponent<Transform>().rotation);
        nuevaFlecha.GetComponent<Transform>().localScale = new Vector3(0.5F, 0.5F, 0.5F);

        //La adjuntamos con el arco
        nuevaFlecha.GetComponent<Transform>().SetParent(bow.GetComponent<Transform>());

        //La ocultamos
        nuevaFlecha.SetActive(false);

        return nuevaFlecha;
    }
    
}
