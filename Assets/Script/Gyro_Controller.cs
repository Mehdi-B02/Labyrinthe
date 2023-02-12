using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gyro_Controller : MonoBehaviour
{
    float maxAngles = 15f;

    void Start()
    {

    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = -Input.GetAxis("Vertical");

        Vector3 rotate = new Vector3(vertical,0,horizontal);

        transform.eulerAngles = rotate * maxAngles;
    }
}

    
