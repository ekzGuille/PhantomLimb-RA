﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotatorMenuLeg : MonoBehaviour
{
    public float x, y, z;
    public GameObject auxLegRotator;
    public Dropdown dropdown;
    public int direction;

    // Start is called before the first frame update
    void Start()
    {
        direction = UserSettings.Rotacion == 0 ? 1 : UserSettings.Rotacion;
        if (dropdown != null)
        {
            dropdown.onValueChanged.AddListener((valor) => ChangeLeg(valor));
        }
    }

    // Update is called once per frame
    void Update()
    {
        auxLegRotator.transform.Rotate(x, y * direction, z, Space.Self);
    }

    void ChangeLeg(int value)
    {
        if (value == 0)
        {
            // Mostrar pierna derecha
            direction = 1;
            UserSettings.Rotacion = direction;
        }
        else
        {
            // Mostrar pierna izquierda
            direction = -1;
            UserSettings.Rotacion = direction;
        }
    }
}
