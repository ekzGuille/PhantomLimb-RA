using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class ArduinoMovement : MonoBehaviour
{
    private const string WINDOWS_PORT = "COM";
    private const string MAC_PORT = "/dev/tty.usbmodem14101";
    private const int PORT = 9600;

    private const float MIN_MOV = 0.0f;
    private const float MAX_MOV = 400.0f;
    private float speed = 0.1f;
    private float movement;

    SerialPort serial = new SerialPort(MAC_PORT, PORT); // Puerto, baudios

    // Start is called before the first frame update
    void Start()
    {
        serial.Open();
        serial.ReadTimeout = 100;
    }

    // Update is called once per frame
    void Update()
    {

        movement = speed * Time.deltaTime;
        if (serial.IsOpen)
        {
            try
            {
                MoveLeg(float.Parse(serial.ReadLine()));
                Debug.Log("Esto es la lectura del arduino : " + serial.ReadLine());
            }
            catch (System.Exception)
            {
            }
        }
    }

    void MoveLeg(float legMovement)
    {
        transform.Translate(Vector3.left * legMovement, Space.World);

    }
}
