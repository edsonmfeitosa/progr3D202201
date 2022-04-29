using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimentoBolinha : MonoBehaviour
{
    public float movX;
    public float movZ;
    public float velocidade;
    [SerializeField]
    private float forca_Pulo;

    public KeyCode paraFrente;
    public KeyCode paraTraz;
    public KeyCode esquerda;
    public KeyCode direita;
    Rigidbody fisica;

    bool podePular = false;

    public AudioClip somPulo;
    public AudioClip somItem;
    AudioSource audio;

    public Pontuacao pt;

    void Start()
    {
        fisica = GetComponent<Rigidbody>();
        audio = GetComponent<AudioSource>();
    }

    
    void Update()
    {
        if (pt.pegouTesouro)
        {
            //if (!audio.isPlaying)
            //{
                //audio.clip = somItem;
                //audio.Play();
                //audio.Stop();
                //audio.Pause();
                audio.PlayOneShot(somItem);
            //}
            
            pt.pegouTesouro = false;
        }


        #region 1ª maneira de pegar o valor do jogador
        //movX = Input.GetAxis("Horizontal");
        //movZ = Input.GetAxis("Vertical");
        #endregion

        #region 2ª maneirea de pegar o valor do jogador
        if (Input.GetKey(paraFrente))
        {
            movZ = 1;
        }
        if (Input.GetKey(paraTraz))
        {
            movZ = -1;
        }
        if (Input.GetKey(esquerda))
        {
            movX = -1;
        }
        if (Input.GetKey(direita))
        {
            movX = 1;
        }
        #endregion

        Vector3 move = new Vector3(movX * Time.deltaTime, 0, movZ * Time.deltaTime);

        #region 1ª forma de movimento
        //transform.Translate(move * velocidade);
        #endregion

        #region 2ª forma de movimento
        fisica.AddForce(move * velocidade);
        #endregion

        #region 3ª forma de movimento
        //fisica.velocity = move * velocidade;
        #endregion

        //pulo da bolinha
        if (Input.GetKeyDown(KeyCode.Space) && podePular)
        {
            fisica.AddForce(Vector3.up * forca_Pulo, ForceMode.Impulse);
            //som do pulo
            //if (!audio.isPlaying)
            //{
            //    audio.clip = somPulo;
            //    audio.Play();
            //}
            audio.PlayOneShot(somPulo);
            
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Chao")
        {
            podePular = true;
        }   
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.collider.tag == "Chao")
        {
            podePular = false;
        }
    }
}
