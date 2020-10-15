using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PopUps : MonoBehaviour
{
    public GameObject popup1;
    public GameObject popup2;
    public GameObject settings;
    private string nome_cena;

    public void desabilitar(){
        if(!popup2.activeSelf){popup1.SetActive(false); settings.SetActive(true);}
    }

    public void mudarnome(string nome){
        nome_cena = nome;
    }

    public void mudarcena(){
        SceneManager.LoadScene(nome_cena);
    }

}
