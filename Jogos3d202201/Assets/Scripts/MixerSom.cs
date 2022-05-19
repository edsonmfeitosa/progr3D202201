using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MixerSom : MonoBehaviour
{
    public AudioMixer mix;
    public float somAnel;
    public float somLeao;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //mix.GetFloat("volumeAnel", out somAnel);
        //mix.GetFloat("volumeLeao", out somLeao);
        mix.SetFloat("volumeAnel", somAnel);
        mix.SetFloat("volumeLeao", somLeao);
    }
}
