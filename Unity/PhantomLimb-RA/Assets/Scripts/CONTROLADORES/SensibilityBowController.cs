using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SensibilityBowController : MonoBehaviour
{
    public Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        slider.onValueChanged.AddListener((value) => CambiarSensibilidadSensor(value));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    static void CambiarSensibilidadSensor(float value)
    {
        switch (value)
        {
            case 1:
                // Claro
                BowController.sensibilidadArduino = 20000;
                Debug.Log("Cambiado a 1");
                break;

            case 2:
                // Normal
                BowController.sensibilidadArduino = 18000;
                Debug.Log("Cambiado a 2");
                break;

            case 3:
                // Oscura
                BowController.sensibilidadArduino = 16000;
                Debug.Log("Cambiado a 3");
                break;
            case 4:
                // Oscura
                BowController.sensibilidadArduino = 15000;
                Debug.Log("Cambiado a 4");
                break;
            case 5:
                // Oscura
                BowController.sensibilidadArduino = 14000;
                Debug.Log("Cambiado a 5");
                break;
        }
    }
}
