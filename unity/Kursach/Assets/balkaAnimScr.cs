using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class balkaAnimScr : MonoBehaviour, IPointerClickHandler
{
    public Animator anim;
    public int i = 0;
    public static bool stateBalka = false;
    public GameObject studyBudy;

    public void OnPointerClick(PointerEventData eventData)
    {
        if (i == 0)
        {
            studyBudy.GetComponent<BoxCollider>().enabled = false;
            stateBalka = true;
            anim.Play("podvizhBalkaAnim");
            i = 1;
        }
        else
        {
            studyBudy.GetComponent<BoxCollider>().enabled = true;
            stateBalka = false;
            anim.Play("podvizhBalkaBackAnim");
            i = 0;
        }
        
    }
}
