using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparoBala : MonoBehaviour
{
    Rigidbody forca;
    public float velocidade;
    void Start()
    {
        forca = GetComponent<Rigidbody>();
        forca.AddForce(transform.forward * velocidade, ForceMode.Impulse);
    }


    void Update()
    {

    }
}
