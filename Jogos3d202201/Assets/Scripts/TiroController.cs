using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiroController : MonoBehaviour
{
    [SerializeField]
    private GameObject canoDaArma;
    [SerializeField]
    private GameObject bala;
    void Start()
    {
        
    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var b = Instantiate(bala, canoDaArma.transform.position, canoDaArma.transform.rotation);
            Destroy(b, 5);
        }
    }
}
