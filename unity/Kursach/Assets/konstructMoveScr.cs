using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class konstructMoveScr : MonoBehaviour
{
    public GameObject thisObj;
    public GameObject magnet;
    public GameObject butThis;
    public GameObject studyBudy;
    public GameObject balka;
    public Slider slider;
    public Button buttonToStart;
    public Button buttonBackToStart;
    float speed = 0.1f;
    bool state = false;
    public static bool stateTS = true;
    public static bool stateBTS = false;

    bool move;
    bool moveMagnet;
    int i = 0;
    float offset = 0;

    public void ToStartPos()
    {
        
        butStartAnimScr.move = false;
        balka.GetComponent<BoxCollider>().enabled = false;
        studyBudy.GetComponent<BoxCollider>().enabled = false;
        Collider col = butThis.GetComponent<Collider>();
        col.enabled = true;
        stateTS = false;
        stateBTS = true;
        offset = 0;
        i = 1;
        move = true;
        moveMagnet = true;
        slider.interactable = true;
        butStartAnimScr.kolvo = 0;
        butStartAnimScr.timer = 0.00f;
    }

    public void BackToStartPos()
    {
        butStartAnimScr.move = false;
        balka.GetComponent<BoxCollider>().enabled = true;
        studyBudy.GetComponent<BoxCollider>().enabled = true;
        stateTS = true;
        stateBTS = false;
        state = false;
        offset = 0;
        i = 2;
        move = true;
        moveMagnet = true;
        slider.interactable = false;
        butStartAnimScr.kolvo = 0;
        butStartAnimScr.timer = 0.00f; ;
    }

    void Update()
    {


        if(stateTS)
        {
            if (studyBudyAnimScr.massState == false && balkaAnimScr.stateBalka == true || studyBudyAnimScr.massState == true)
            {
                buttonToStart.interactable = true;
            }
            else
            {
                buttonToStart.interactable = false;
            }
        }
        else
            buttonToStart.interactable = false;

        if(stateBTS)
            buttonBackToStart.interactable = true;
        else
            buttonBackToStart.interactable = false;


        if (state)
        {
            if (studyBudyAnimScr.massState == true)
            {
                transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(-90, 0, 180 + slider.value), 1);
                magnet.transform.position = Vector3.Lerp(transform.position, new Vector3((thisObj.transform.position.x - 0.008f), (thisObj.transform.position.y + 0.001f), (thisObj.transform.position.z - 0.008f)), 1);
                magnet.transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0f, (180f + slider.value - 48.087f), 0f), 1);
            }
            else
            {
                transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(-90, 0, 180 + slider.value), 1);
                magnet.transform.position = Vector3.Lerp(transform.position, new Vector3((thisObj.transform.position.x - 0.008f), (thisObj.transform.position.y + 0.001f), (thisObj.transform.position.z - 0.008f)), 1);
                magnet.transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0f, (180f + slider.value - 48.087f), 0f), 1);
                studyBudy.transform.rotation = Quaternion.Lerp(studyBudy.transform.rotation, Quaternion.Euler(0, 0 + slider.value, 0), 1);
            }
        }

        if (move)
        {
            if (i == 1)
            {
                if (offset <= 1)
                {
                    if (studyBudyAnimScr.massState == true)
                    {
                        offset += speed;
                        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(-90, 0, 180 + slider.value), offset);
                    }
                    else
                    {
                        offset += speed;
                        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(-90, 0, 180 + slider.value), offset);
                        studyBudy.transform.rotation = Quaternion.Lerp(studyBudy.transform.rotation, Quaternion.Euler(0, 0 + slider.value, 0), offset);
                    }
                }
                else
                { 
                    i = 0;
                    move = false;
                    slider.value = 40;
                    state = true;
                }
            }
            else if (i == 2)
            {
                if (offset <= 1)
                {
                    offset += speed;
                    if(transform.rotation == Quaternion.Euler(-90, 0, 180 + 40))
                    {
                        moveMagnet = false;
                    }
                    if(moveMagnet)
                    {
                        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(-90, 0, 180 + 40), offset);
                        magnet.transform.position = Vector3.Lerp(transform.position, new Vector3((thisObj.transform.position.x - 0.008f), (thisObj.transform.position.y + 0.001f), (thisObj.transform.position.z - 0.008f)), 1);
                        magnet.transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0f, (180f + 40 - 48.087f), 0f), 1);
                    }
                    if (studyBudyAnimScr.massState == true)
                    {
                        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(-90, 0, 180), offset);
                    }
                    else
                    {
                        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(-90, 0, 180), offset);
                        studyBudy.transform.rotation = Quaternion.Lerp(studyBudy.transform.rotation, Quaternion.Euler(0, 0, 0), offset);
                    }
                }
                else
                {
                    i = 0;
                    move = false;
                    slider.value = 40;

                }
            }
            else
                i = 0;
        }
    }
}
