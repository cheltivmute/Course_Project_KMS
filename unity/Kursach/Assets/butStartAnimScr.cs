using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System;
using System.Diagnostics;
using Debug = UnityEngine.Debug;
using TMPro;

public class butStartAnimScr : MonoBehaviour, IPointerClickHandler
{
    public GameObject konstuct;
    public GameObject magnet;
    public GameObject butThis;
    public GameObject studyBudy;
    //public GameObject triggerCol;
    public TMP_Text textKolvo;
    public TMP_Text textTimer;
    public Button butToStart;
    public Button butToStartPos;
    public Slider slider;
    float massKoef;
    float newAngle;
    public static bool move;
    public static float timer = 0;
    float offset = 0;
    //float offsetTrigger = 0.005f;
    public static int kolvo;
    float period;
    double momInRam = 6.84 * Math.Pow(10, -4);
    double momInTela = 13.5 * Math.Pow(10, -4);


    public Animator anim;
    public int i = 0;

    void Start()
    {
        Collider col = butThis.GetComponent<Collider>();
        col.enabled = false;
    }

    public void OnPointerClick(PointerEventData eventData)
    {

        if (i == 0)
        {
            if (studyBudyAnimScr.massState == true)
                massKoef = 0.96f;
            else
                massKoef = 0.55f;
            anim.Play("butStartAnim");
            konstructMoveScr.stateTS = false;
            konstructMoveScr.stateBTS = false;
            Collider col = butThis.GetComponent<Collider>();
            col.enabled = false;
            slider.interactable = false;
            kolvo = 0;
            offset = 0;
            timer = 0;
            move = true;
            i = 1;
        }
        else
        {
            if (studyBudyAnimScr.massState == true)
                massKoef = 0.96f;
            else
                massKoef = 0.55f;
            anim.Play("butStartAnim1");
            konstructMoveScr.stateTS = false;
            konstructMoveScr.stateBTS = false;
            slider.interactable = false;
            Collider col = butThis.GetComponent<Collider>();
            col.enabled = false;
            kolvo = 0;
            offset = 0;
            timer = 0;
            move = true;
            i = 0;
        }
    }

    void Update()
    {
        textKolvo.text = kolvo.ToString();

        if (move)
        {
            if (kolvo >= 0 && kolvo < 10)
                timer = (float)Math.Round((timer + Time.deltaTime), 2);

            if (studyBudyAnimScr.massState == true )
            {
                offset += Time.deltaTime;
                newAngle = (float)((Math.Pow(1.5, (-offset * 0.25)) * Math.Cos(2 * Math.PI * offset * massKoef) * slider.value));
                konstuct.transform.rotation = Quaternion.Lerp(konstuct.transform.rotation, Quaternion.Euler(-90, 0, 180 + newAngle), 100);
            }
            else
            {
                offset += Time.deltaTime;
                newAngle = (float)((Math.Pow(1.5, (-offset * 0.25)) * Math.Cos(2 * Math.PI * offset * massKoef) * slider.value));
                konstuct.transform.rotation = Quaternion.Lerp(konstuct.transform.rotation, Quaternion.Euler(-90, 0, 180 + newAngle), 100);
                studyBudy.transform.rotation = Quaternion.Lerp(studyBudy.transform.rotation, Quaternion.Euler(0, newAngle, 0), 100);
            }
                

            if(kolvo == 10)
            {
                konstructMoveScr.stateTS = true;
                konstructMoveScr.stateBTS = true;
            }
            
        }

        if (timer > 0)
        {
            textTimer.text = string.Format("{0:00.00}", timer).Replace(',', ':');
        }
        else
        {
            textTimer.text = "00:00";
        }
    }
}
