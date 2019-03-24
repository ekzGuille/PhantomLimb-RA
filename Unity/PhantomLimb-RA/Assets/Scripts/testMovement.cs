﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class testMovement : MonoBehaviour
{

    private const float MIN_MOV = 0.0f;
    private const float MAX_MOV = 400.0f;
    private float speed;
    private float movement;

    SerialPort serial = new SerialPort("COM3", 9600); // Puerto, baudios

    // Start is called before the first frame update
    void Start()
    {
        serial.Open();
        serial.ReadTimeout = 1;
    }

    // Update is called once per frame
    void Update()
    {
        movement = speed * Time.deltaTime;
        if (serial.IsOpen)
        {
            try
            {
                MoveLeg(serial.ReadByte());
                print(serial.ReadByte());
            }
            catch (System.Exception)
            {

            }
        }
    }

    void MoveLeg(float legMovement)
    {
        //transform.Translate(Vector3.left * movement, Space.World);
        transform.Translate(Vector3.left * legMovement, Space.World);

    }
}
