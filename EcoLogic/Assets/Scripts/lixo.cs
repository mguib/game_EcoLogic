using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class lixo : MonoBehaviour
{

    public GameObject victory;
    public GameObject victory_text;

    void Start(){
        victory.SetActive(false);
        victory_text.SetActive(false);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Lata")
        {
            GameController.qtdeLixos--;
            Debug.Log(GameController.qtdeLixos);            
            //SceneManager.LoadScene(levelName);
            Destroy(gameObject);
        }

        if (GameController.qtdeLixos == 0)
        {
            Debug.Log("Venceu");
            victory.SetActive(true);
            victory_text.SetActive(true);
            PlayerPrefs.SetInt(SceneManager.GetActiveScene().name, 1);
        }
    }
}
