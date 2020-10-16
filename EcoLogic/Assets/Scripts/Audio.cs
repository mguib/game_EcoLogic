using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Audio : MonoBehaviour
{

   AudioSource audioo;
   public static bool playing = true;
   public static bool isFirst;
   public GameObject redbar;

   void Start(){
       isFirst = false;
        audioo = GetComponent<AudioSource>();
       if(playing & !isFirst){audioo.Play();}
       else{redbar.SetActive(true);}
   }

   public void pause_music(){
       if(!playing & isFirst) {audioo.UnPause();playing=true;isFirst=false;redbar.SetActive(false);}
       else if(playing & !isFirst) {audioo.Pause();playing=false;isFirst=true;redbar.SetActive(true);}  
       else if(!playing & !isFirst){audioo.Play(); playing=true; isFirst=false;redbar.SetActive(false);}
   }
}
