using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pontuacao : MonoBehaviour
{
    private int quantidade = 0;
    public float tempo = 0;
    public Text txtTempo;
    
    public bool pegouTesouro = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tempo += Time.deltaTime;
        txtTempo.text = "Tempo: " + tempo.ToString("00.00");
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "tesouro")
        {
            pegouTesouro = true;
            quantidade++;
            Destroy(other.gameObject);
            print("Quantidade de itens: " + quantidade);
        }
    }
}
