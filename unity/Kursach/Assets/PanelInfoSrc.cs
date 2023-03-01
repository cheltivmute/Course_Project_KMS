using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelInfoSrc : MonoBehaviour
{
    void Start()
    {
        Close(); //  ÇÀÊĞÛÒÜ ÂÑÏËÛÂÀŞÙÅÅ ÎÊÍÎ ÏĞÈ ÇÀÏÓÑÊÅ ÏĞÎÃĞÀÌÌÛ  
    }

    public void Open()
    {
        gameObject.SetActive(true);
    }

    public void Close()
    {
        gameObject.SetActive(false);
    }
}
