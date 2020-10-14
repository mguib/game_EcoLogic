using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cenas : MonoBehaviour
{
    public void mudarCena(string nome){
        SceneManager.LoadScene(nome);
    }
}
