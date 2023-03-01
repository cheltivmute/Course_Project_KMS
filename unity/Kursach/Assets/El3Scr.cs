using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class El3Scr : MonoBehaviour
{

    public void ChangCol()
    {
        GetComponent<Renderer>().material.color = new Color(0, 1, 0);
    }

    public void ChangCol1()
    {
        GetComponent<Renderer>().material.color = new Color(0, 0, 0);
    }

}
