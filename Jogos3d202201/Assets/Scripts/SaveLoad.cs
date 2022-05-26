using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveLoad : MonoBehaviour
{
    public Canvas telaSave;
    public KeyCode teclaSaveLoad;
    bool habilitaTela = false;

    public InputField InputNomeSave;
    public Text txtNomeSalvo;

    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(teclaSaveLoad))
        {
            habilitaTela = !habilitaTela;
            if (habilitaTela)
            {
                //abri tela de Save/Load
                Time.timeScale = 0;
                telaSave.gameObject.SetActive(true);

                if (PlayerPrefs.HasKey("save1"))
                {
                    txtNomeSalvo.text = PlayerPrefs.GetString("save1");
                }

            }
            else
            {
                //fechar tela de Save/Load
                Time.timeScale = 1;
                telaSave.gameObject.SetActive(false);
            }
        }
    }

    public void Salvar()
    {
        txtNomeSalvo.text = InputNomeSave.text;
        PlayerPrefs.SetString("save1", InputNomeSave.text);
        PlayerPrefs.SetFloat("save1.posx", player.transform.position.x);
        PlayerPrefs.SetFloat("save1.posy", player.transform.position.y);
        PlayerPrefs.SetFloat("save1.posz", player.transform.position.z);
        PlayerPrefs.SetFloat("save1.tempo", player.GetComponent<Pontuacao>().tempo);
    }
    public void Load()
    {
        float x = PlayerPrefs.GetFloat("save1.posx");
        float y = PlayerPrefs.GetFloat("save1.posy");
        float z = PlayerPrefs.GetFloat("save1.posz");
        float tempo = PlayerPrefs.GetFloat("save1.tempo");
        Vector3 posicao = new Vector3(x, y, z);
        player.transform.position = posicao;
        player.GetComponent<Pontuacao>().tempo = tempo;
    }
    public void ApagarSaves()
    {
        PlayerPrefs.DeleteAll();
        txtNomeSalvo.text = "<<Save1>>";
    }
}
