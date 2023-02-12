using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBalls : MonoBehaviour
{
    [SerializeField] GameObject prefab;
    void Start()
    {
        Instantiate(prefab,transform.position, Quaternion.identity);
    }
}
