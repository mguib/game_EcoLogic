using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;// Required when using Event data.

public class Cima : MonoBehaviour, IPointerDownHandler, IPointerUpHandler// required interface when using the OnPointerDown method.
{
    public static bool pressionando = false;

    //Do this when the mouse is clicked over the selectable object this script is attached to.
    public void OnPointerDown(PointerEventData eventData)
    {
        pressionando = true;
        //Debug.Log(this.gameObject.name + " Was Clicked.");
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        pressionando = false;
    }
}