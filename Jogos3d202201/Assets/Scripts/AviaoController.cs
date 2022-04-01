using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AviaoController : MonoBehaviour
{
    [Header("Principal")]
    public bool ligado;
    [Header("Hélice")]
    public Transform helice;
    public float velocidadeHelice;
    float velocidadeInicialHelice = 1;
    [Header("Input Avião")]
    public KeyCode acelerar;
    public KeyCode frear;
    public KeyCode paraCima;
    public KeyCode paraBaixo;
    public KeyCode esquerda;
    public KeyCode direita;
    float velocidade = 0;
    public float fatorGiro;
    void Start()
    {
        
    }

    void Update()
    {
        if (ligado)
        {
            if (giraHelice())
            {
                movimento();
            }
        }
        
        
    }

    private void movimento()
    {
        float movZ = 0;
        float movX = 0;
        #region aceleração do avião
        if (Input.GetKey(acelerar))
        {
            velocidade--;
        }
        if (Input.GetKey(frear))
        {
            velocidade++;
            if (velocidade > 0)
            {
                velocidade = 0;
            }    
        }
        #endregion
        //esquerda - diminui em z
        if (Input.GetKey(esquerda))
        {
            movZ = -1;
        }
        if (Input.GetKey(direita))
        {
            movZ = 1;
        }
        //pra cima - diminui em x
        if (Input.GetKey(paraCima))
        {
            movX = -1;
        }
        if (Input.GetKey(paraBaixo))
        {
            movX = 1;
        }
        transform.Translate(Vector3.up * velocidade);//new Vector3(0,1,0)
        transform.Rotate(
            new Vector3(movX * fatorGiro, movZ * fatorGiro, movZ * fatorGiro));
    }

    public bool giraHelice()
    {
        if (velocidadeInicialHelice <= velocidadeHelice)
        {
            velocidadeInicialHelice = velocidadeInicialHelice + 3;
        }
        helice.Rotate(
            new Vector3(0, 1 * velocidadeInicialHelice * Time.deltaTime, 0));

        if (velocidadeInicialHelice > (velocidadeHelice / 4))
            return true;
        else
            return false;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "jogador")
        {
            //Destroy(collision.gameObject);
            collision.gameObject.SetActive(false);
            ligado = true;
        }
    }
}
