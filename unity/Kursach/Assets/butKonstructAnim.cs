using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class butKonstructAnim : MonoBehaviour, IPointerClickHandler
{
    public Animator anim;
    public int i = 0;

    public void OnPointerClick(PointerEventData eventData)
    {
        if (i == 0)
        {
            anim.Play("konstructAnim");
            i++;
        }
        else
        {
            anim.Play("konstructBackAnim");
            i = 0;
        }

    }
}
