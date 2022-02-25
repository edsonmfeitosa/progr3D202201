using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimentoCam : MonoBehaviour
{
    public GameObject bolinha;
    private Vector3 posicaoInicial;
    private Vector3 posicaoAtual;
    void Start()
    {
        posicaoInicial = bolinha.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        posicaoAtual = bolinha.transform.position;
        transform.position = transform.position + (posicaoAtual - posicaoInicial);
        posicaoInicial = bolinha.transform.position;
    }
}
