using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Cenas : MonoBehaviour
{

    public List<Button> botoes;

    private void Start(){
        for (int i = 1; i < botoes.Count; i++){
            if (PlayerPrefs.GetInt("Fase1_" + i.ToString()) == 1){
                botoes[i].interactable = true;
            }

        }
    }

    public void mudarCena(string nome){
        SceneManager.LoadScene(nome);
    }

    public void apagar(){
        PlayerPrefs.DeleteAll();
        for (int i = 0; i < botoes.Count; i++){
            if (i != 0) botoes[i].interactable = false;
        }
    }

   
}
