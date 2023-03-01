using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class studyBudyAnimScr : MonoBehaviour, IPointerClickHandler
{
    public Animator anim;
    public static bool massState = true;
    public int i = 0;
    

    public void OnPointerClick(PointerEventData eventData)
    {
        if (i == 0)
        {
            
            massState = false;
            anim.Play("budyPlaceAnim");
            i = 1;
        }
        else
        {
            
            massState = true;
            anim.Play("budyBackAnim");
            i = 0;
        }

    }
}
