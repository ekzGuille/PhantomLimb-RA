using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    private bool active;

    // Start is called before the first frame update
    void Start()
    {
        active = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collision)
    {
        if (!active)
        {
            int pts = 0;
            UnityEngine.UI.Text texto = GameObject.FindGameObjectWithTag("puntos").GetComponent<UnityEngine.UI.Text>();
            if (collision.gameObject.name == "t5")
            {
                pts = 5;
                active = true;
            }
            else if (collision.gameObject.name == "target_10")
            {
                pts = 10;
                active = true;
            }
            else if (collision.gameObject.name == "target_25")
            {
                pts = 25;
                active = true;
            }
            else if (collision.gameObject.name == "target_50")
            {
                pts = 50;
                active = true;
            }
            else if (collision.gameObject.name == "target_100")
            {
                pts = 100;
                active = true;
            }
            int number = 0;
            int.TryParse((texto.text), out number);
            pts = pts + number;
            texto.text = pts.ToString();
        }
        StartCoroutine(Tiempo());
    }

    IEnumerator Tiempo()
    {
        yield return new WaitForSeconds(1);
        active = false;
    }
}
