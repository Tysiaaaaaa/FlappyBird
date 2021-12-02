using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{

    public GameObject przeszkoda;
    void Start()
    {
        InvokeRepeating("StworzPrzeszkode", 1,3);
    }

    void StworzPrzeszkode()
    {
        Debug.Log("StworzPrzeszkode");
        Instantiate(przeszkoda, transform.position,Quaternion.identity);
    }
}
