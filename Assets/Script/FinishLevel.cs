using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLevel : MonoBehaviour
{
    void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.tag == "Ball")
        {
            Debug.Log("FINISH");
        } 
    }
}
