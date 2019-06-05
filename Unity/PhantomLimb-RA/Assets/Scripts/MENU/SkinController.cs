using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SkinController : MonoBehaviour
{
    public Slider slider;
    public Material m_skin;
    public Material m_skin_light;
    public Material m_skin_dark;

    public Dropdown dropdown;

    public GameObject piernaL;
    public GameObject piernaR;

    // Start is called before the first frame update
    void Start()
    {
        piernaL.SetActive(false);
        piernaR.SetActive(true);
        slider.onValueChanged.AddListener((value) => ChangeSkinLeg(value));

        dropdown.onValueChanged.AddListener((valor) => ChangeLeg(valor));
      
    }

    // Update is called once per frame
    void Update()
    {

    }

    void ChangeSkinLeg(float value)
    {
        switch (value)
        {
            case 1:
                // Claro
                if (dropdown.captionText.text == "Pierna Derecha")
                {
                    piernaR.GetComponent<Renderer>().material = m_skin_light;

                }
                else
                {
                    piernaL.GetComponent<Renderer>().material = m_skin_light;

                }
                break;

            case 2:
                // Normal
                if (dropdown.captionText.text == "Pierna Derecha")
                {
                    piernaR.GetComponent<Renderer>().material = m_skin;

                }
                else
                {
                    piernaL.GetComponent<Renderer>().material = m_skin;

                }

                break;
            case 3:
                // Oscura
                if (dropdown.captionText.text == "Pierna Derecha")
                {
                    piernaR.GetComponent<Renderer>().material = m_skin_dark;

                }
                else
                {
                    piernaL.GetComponent<Renderer>().material = m_skin_dark;

                }
                break;
        }
    }

    void ChangeLeg(int value)
    {
        if(value == 0)
        {
            // Mostrar pierna derecha
            piernaL.SetActive(false);
            piernaR.SetActive(true);
        }else
        {
            // Mostrar pierna izquierda
            piernaR.SetActive(false);
            piernaL.SetActive(true);
        }
    }
}
