using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Storyboard : MonoBehaviour
{
    public static string testes;
    private int count;
    public Image actual;
    public List<Sprite> images;

    void Start(){
        count = 0;
        testes = "1";
    }

    public void switch_image(){
        if(count < 3) actual.sprite = images[count];
        count++;
        if(count == 4) SceneManager.LoadScene("Fases");
    }
    
}
