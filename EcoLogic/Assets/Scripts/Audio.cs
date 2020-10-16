using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Audio : MonoBehaviour
{

   AudioSource audioo;
   public static bool playing = true;
   public static bool isFirst;

   void Start(){
       isFirst = false;
        audioo = GetComponent<AudioSource>();
       if(playing & !isFirst){audioo.Play();}
   }

   public void pause_music(){
       if(!playing & isFirst) {audioo.UnPause();playing=true;isFirst=false;}
       else if(playing & !isFirst) {audioo.Pause();playing=false;isFirst=true;}  
       else if(!playing & !isFirst){audioo.Play(); playing=true; isFirst=false;}
   }
}
