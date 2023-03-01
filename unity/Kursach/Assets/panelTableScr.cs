using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panelTableScr : MonoBehaviour
{
    void Start()
    {
        Close(); //  гюйпшрэ бяокшбючыее нймн опх гюосяйе опнцпюллш  
    }

    public void Open()
    {
        gameObject.SetActive(true); //   юйрхбхпнбюрэ назейр, врнаш нрйпшрэ нймн.  
    }

    public void Close()
    {
        gameObject.SetActive(false); // деюйрхбхпнбюрэ назейр, врнаш гюйпшрэ нймн.  
    }
}
