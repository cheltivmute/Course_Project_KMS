using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System.Diagnostics;
using System;

public class rasschitatScr : MonoBehaviour
{
    public Slider slider;

    public int a = 1;
    public int b = 1;
    public int c = 1;
    public int d = 1;

    public Text textN11;
    public Text textN12;
    public Text textN13;
    public Text textN21;
    public Text textN22;
    public Text textN23;
    public Text textt11;
    public Text textt12;
    public Text textt13;
    public Text textt21;
    public Text textt22;
    public Text textt23;
    public Text textT11;
    public Text textT12;
    public Text textT13;
    public Text textT21;
    public Text textT22;
    public Text textT23;
    public Text textTsr1;
    public Text textTsr2;
    public Text textTdel1;
    public Text textTdel22;

    public Text textN11telo;
    public Text textN12telo;
    public Text textN13telo;
    public Text textN21telo;
    public Text textN22telo;
    public Text textN23telo;
    public Text textt11telo;
    public Text textt12telo;
    public Text textt13telo;
    public Text textt21telo;
    public Text textt22telo;
    public Text textt23telo;
    public Text textT11telo;
    public Text textT12telo;
    public Text textT13telo;
    public Text textT21telo;
    public Text textT22telo;
    public Text textT23telo;
    public Text textTsr1telo;
    public Text textTsr2telo;
    public Text textTdel1telo;
    public Text textTdel22telo;

    float textN11f;
    float textN12f;
    float textN13f;
    float textN21f;
    float textN22f;
    float textN23f;
    float textt11f;
    float textt12f;
    float textt13f;
    float textt21f;
    float textt22f;
    float textt23f;
    float textT11f;
    float textT12f;
    float textT13f;
    float textT21f;
    float textT22f;
    float textT23f;
    float textTsr1f;
    float textTsr2f;
    float textTdel1f;
    float textTdel22f;

    float textN11telof;
    float textN12telof;
    float textN13telof;
    float textN21telof;
    float textN22telof;
    float textN23telof;
    float textt11telof;
    float textt12telof;
    float textt13telof;
    float textt21telof;
    float textt22telof;
    float textt23telof;
    float textT11telof;
    float textT12telof;
    float textT13telof;
    float textT21telof;
    float textT22telof;
    float textT23telof;
    float textTsr1telof;
    float textTsr2telof;
    float textTdel1telof;
    float textTdel22telof;

    public void zapisat()
    {
        if(studyBudyAnimScr.massState == true)
        {
            if (slider.value == 40)
            {
                if (a == 1)
                {
                    textN11f = butStartAnimScr.kolvo;
                    textt11f = butStartAnimScr.timer;
                    textN11.text = butStartAnimScr.kolvo.ToString();
                    textt11.text = butStartAnimScr.timer.ToString();
                    a++;
                }
                else if (a == 2)
                {
                    textN12f = butStartAnimScr.kolvo;
                    textt12f = butStartAnimScr.timer;
                    textN12.text = butStartAnimScr.kolvo.ToString();
                    textt12.text = butStartAnimScr.timer.ToString();
                    a++;
                }
                else if (a == 3)
                {
                    textN13f = butStartAnimScr.kolvo;
                    textt13f = butStartAnimScr.timer;
                    textN13.text = butStartAnimScr.kolvo.ToString();
                    textt13.text = butStartAnimScr.timer.ToString();
                    a++;
                }
            }
            else
            {
                if (b == 1)
                {
                    textN21f = butStartAnimScr.kolvo;
                    textt21f = butStartAnimScr.timer;
                    textN21.text = butStartAnimScr.kolvo.ToString();
                    textt21.text = butStartAnimScr.timer.ToString();
                    b++;
                }
                else if (b == 2)
                {
                    textN22f = butStartAnimScr.kolvo;
                    textt22f = butStartAnimScr.timer;
                    textN22.text = butStartAnimScr.kolvo.ToString();
                    textt22.text = butStartAnimScr.timer.ToString();
                    b++;
                }
                else if (b == 3)
                {
                    textN23f = butStartAnimScr.kolvo;
                    textt23f = butStartAnimScr.timer;
                    textN23.text = butStartAnimScr.kolvo.ToString();
                    textt23.text = butStartAnimScr.timer.ToString();
                    b++;
                }
            }
        }
        else
        {

            if (slider.value == 40)
            {
                if (c == 1)
                {
                    textN11telof = butStartAnimScr.kolvo;
                    textt11telof = butStartAnimScr.timer;
                    textN11telo.text = butStartAnimScr.kolvo.ToString();
                    textt11telo.text = butStartAnimScr.timer.ToString();
                    c++;
                }
                else if (c == 2)
                {
                    textN12telof = butStartAnimScr.kolvo;
                    textt12telof = butStartAnimScr.timer;
                    textN12telo.text = butStartAnimScr.kolvo.ToString();
                    textt12telo.text = butStartAnimScr.timer.ToString();
                    c++;
                }
                else if (c == 3)
                {
                    textN13telof = butStartAnimScr.kolvo;
                    textt13telof= butStartAnimScr.timer;
                    textN13telo.text = butStartAnimScr.kolvo.ToString();
                    textt13telo.text = butStartAnimScr.timer.ToString();
                    c++;
                }
            }
            else
            {
                if (d == 1)
                {
                    textN21telof = butStartAnimScr.kolvo;
                    textt21telof = butStartAnimScr.timer;
                    textN21telo.text = butStartAnimScr.kolvo.ToString();
                    textt21telo.text = butStartAnimScr.timer.ToString();
                    d++;
                }
                else if (d == 2)
                {
                    textN22telof= butStartAnimScr.kolvo;
                    textt22telof = butStartAnimScr.timer;
                    textN22telo.text = butStartAnimScr.kolvo.ToString();
                    textt22telo.text = butStartAnimScr.timer.ToString();
                    d++;
                }
                else if (d == 3)
                {
                    textN23telof = butStartAnimScr.kolvo;
                    textt23telof = butStartAnimScr.timer;
                    textN23telo.text = butStartAnimScr.kolvo.ToString();
                    textt23telo.text = butStartAnimScr.timer.ToString();
                    d++;
                }
            }
        }
        
    }

    public void ochistit()
    {
        textN11.text = "";
        textN12.text = "";
        textN13.text = "";
        textN21.text = "";
        textN22.text = "";
        textN23.text = "";
        textt11.text = "";
        textt12.text = "";
        textt13.text = "";
        textt21.text = "";
        textt22.text = "";
        textt23.text = "";
        textT11.text = "";
        textT12.text = "";
        textT13.text = "";
        textT21.text = "";
        textT22.text = "";
        textT23.text = "";
        textTsr1.text = "";
        textTsr2.text = "";
        textTdel1.text = "";
        textTdel22.text = "";

        textN11telo.text = "";
        textN12telo.text = "";
        textN13telo.text = "";
        textN21telo.text = "";
        textN22telo.text = "";
        textN23telo.text = "";
        textt11telo.text = "";
        textt12telo.text = "";
        textt13telo.text = "";
        textt21telo.text = "";
        textt22telo.text = "";
        textt23telo.text = "";
        textT11telo.text = "";
        textT12telo.text = "";
        textT13telo.text = "";
        textT21telo.text = "";
        textT22telo.text = "";
        textT23telo.text = "";
        textTsr1telo.text = "";
        textTsr2telo.text = "";
        textTdel1telo.text = "";
        textTdel22telo.text = "";

        textN11f = 0;
        textN12f = 0;
        textN13f = 0;
        textN21f = 0;
        textN22f = 0;
        textN23f = 0;
        textt11f = 0;
        textt12f = 0;
        textt13f = 0;
        textt21f = 0;
        textt22f = 0;
        textt23f = 0;
        textT11f = 0;
        textT12f = 0;
        textT13f = 0;
        textT21f = 0;
        textT22f = 0;
        textT23f = 0;
        textTsr1f = 0;
        textTsr2f = 0;
        textTdel1f = 0;
        textTdel22f = 0;

        textN11telof = 0;
        textN12telof = 0;
        textN13telof = 0;
        textN21telof = 0;
        textN22telof = 0;
        textN23telof = 0;
        textt11telof = 0;
        textt12telof = 0;
        textt13telof = 0;
        textt21telof = 0;
        textt22telof = 0;
        textt23telof = 0;
        textT11telof = 0;
        textT12telof = 0;
        textT13telof = 0;
        textT21telof = 0;
        textT22telof = 0;
        textT23telof = 0;
        textTsr1telof = 0;
        textTsr2telof = 0;
        textTdel1telof = 0;
        textTdel22telof = 0;

        a = 1;
        b = 1;
        c= 1;
        d = 1;
    }

    public void rasschitat()
    {
        if(a == 4 && b == 4 && c == 4 && d == 4)
        {
            textT11f = (float)Math.Round(textt11f / textN11f, 2);
            textT12f = (float)Math.Round(textt12f / textN12f, 2);
            textT13f = (float)Math.Round(textt13f / textN13f, 2);
            textT21f = (float)Math.Round(textt21f / textN21f, 2);
            textT22f = (float)Math.Round(textt22f / textN22f, 2);
            textT23f = (float)Math.Round(textt23f / textN23f, 2);
            textT11.text = textT11f.ToString();
            textT12.text = textT12f.ToString();
            textT13.text = textT13f.ToString();
            textT21.text = textT21f.ToString();
            textT22.text = textT22f.ToString();
            textT23.text = textT23f.ToString();

            textT11telof = (float)Math.Round(textt11telof / textN11telof, 2);
            textT12telof = (float)Math.Round(textt12telof / textN12telof, 2);
            textT13telof = (float)Math.Round(textt13telof / textN13telof, 2);
            textT21telof = (float)Math.Round(textt21telof / textN21telof, 2);
            textT22telof = (float)Math.Round(textt22telof / textN22telof, 2);
            textT23telof = (float)Math.Round(textt23telof / textN23telof, 2);
            textT11telo.text = textT11telof.ToString();
            textT12telo.text = textT12telof.ToString();
            textT13telo.text = textT13telof.ToString();
            textT21telo.text = textT21telof.ToString();
            textT22telo.text = textT22telof.ToString();
            textT23telo.text = textT23telof.ToString();

            textTsr1f = (float)Math.Round((textT11f + textT12f + textT13f) / 3, 2);
            textTsr2f = (float)Math.Round((textT21f + textT22f + textT23f) / 3, 2);
            textTsr1.text = textTsr1f.ToString();
            textTsr2.text = textTsr2f.ToString();

            textTsr1telof = (float)Math.Round((textT11telof + textT12telof + textT13telof) / 3, 2);
            textTsr2telof = (float)Math.Round((textT21telof + textT22telof + textT23telof) / 3, 2);
            textTsr1telo.text = textTsr1telof.ToString();
            textTsr2telo.text = textTsr2telof.ToString();

            textTdel1f = 0.05f;
            textTdel22f = 0.05f;
            textTdel1.text = textTdel1f.ToString();
            textTdel22.text = textTdel22f.ToString();

            textTdel1telof = 0.05f;
            textTdel22telof = 0.05f;
            textTdel1telo.text = textTdel1telof.ToString();
            textTdel22telo.text = textTdel22telof.ToString();
        }
    }
    
}
