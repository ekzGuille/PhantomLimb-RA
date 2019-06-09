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
        if (UserSettings.Pierna != null)
        {
            if (UserSettings.Pierna.Equals("piernaR"))
            {
                piernaL.SetActive(false);
                piernaR.SetActive(true);
                UserSettings.Pierna = "piernaR";
                if (dropdown != null)
                {
                    dropdown.value = 0;
                }
                if (UserSettings.Skin != null && !UserSettings.Skin.Equals(""))
                {
                    piernaR.GetComponent<Renderer>().material = GetSkinColor(UserSettings.Skin);

                }
            }
            else
            {
                piernaR.SetActive(false);
                piernaL.SetActive(true);
                UserSettings.Pierna = "piernaL";
                if (dropdown != null)
                {
                    dropdown.value = 1;
                }
                if (UserSettings.Skin != null && !UserSettings.Skin.Equals(""))
                {
                    piernaL.GetComponent<Renderer>().material = GetSkinColor(UserSettings.Skin);
                }
            }
        }
        else
        {
            piernaL.SetActive(false);
            piernaR.SetActive(true);
            if (dropdown != null)
            {
                dropdown.value = 0;
            }
            UserSettings.Pierna = "piernaR";
        }
        if (slider != null)
        {
            slider.onValueChanged.AddListener((value) => ChangeSkinLeg(value));
        }

        if (dropdown != null)
        {
            dropdown.onValueChanged.AddListener((valor) => ChangeLeg(valor));
        }
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
                piernaR.GetComponent<Renderer>().material = m_skin_light;
                piernaL.GetComponent<Renderer>().material = m_skin_light;
                UserSettings.Skin = "m_skin_light";
                break;

            case 2:
                // Normal
                piernaR.GetComponent<Renderer>().material = m_skin;
                piernaL.GetComponent<Renderer>().material = m_skin;
                UserSettings.Skin = "m_skin";
                break;

            case 3:
                // Oscura
                piernaR.GetComponent<Renderer>().material = m_skin_dark;
                piernaL.GetComponent<Renderer>().material = m_skin_dark;
                UserSettings.Skin = "m_skin_dark";
                break;
        }
    }

    void ChangeLeg(int value)
    {
        if (value == 0)
        {
            // Mostrar pierna derecha
            piernaL.SetActive(false);
            piernaR.SetActive(true);
            UserSettings.Pierna = "piernaR";
            piernaR.GetComponent<Renderer>().material = GetSkinColor(UserSettings.Skin);
        }
        else
        {
            // Mostrar pierna izquierda
            piernaR.SetActive(false);
            piernaL.SetActive(true);
            UserSettings.Pierna = "piernaL";
            piernaL.GetComponent<Renderer>().material = GetSkinColor(UserSettings.Skin);
        }
    }

    Material GetSkinColor(string skinName)
    {
        switch (skinName)
        {
            case "m_skin":
                if (slider != null)
                {
                    slider.value = 2;
                }
                return m_skin;
            case "m_skin_light":
                if (slider != null)
                {
                    slider.value = 1;
                }
                return m_skin_light;
            case "m_skin_dark":
                if (slider != null)
                {
                    slider.value = 3;
                }
                return m_skin_dark;
        }
        return m_skin;
    }



}