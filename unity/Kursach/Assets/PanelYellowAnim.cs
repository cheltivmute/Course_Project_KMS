using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelYellowAnim : MonoBehaviour
{
    [SerializeField]
    public int S;
    public int i = 0;

    void Start()
    {
        Close(); //  ÇÀÊĞÛÒÜ ÂÑÏËÛÂÀŞÙÅÅ ÎÊÍÎ ÏĞÈ ÇÀÏÓÑÊÅ ÏĞÎÃĞÀÌÌÛ  
    }

    public void OnOpenSettings()
    {
        Open();  //  ÎÒÊĞÛÒÜ ÂÑÏËÛÂÀŞÙÅÅ ÒÅÊÑÒÎÂÎÅ ÎÊÍÎ 
    }

    public void Open()
    {
        gameObject.SetActive(true); //   ÀÊÒÈÂÈĞÎÂÀÒÜ ÎÁÚÅÊÒ, ×ÒÎÁÛ ÎÒÊĞÛÒÜ ÎÊÍÎ.  
    }

    public void Close()
    {
        gameObject.SetActive(false); // ÄÅÀÊÒÈÂÈĞÎÂÀÒÜ ÎÁÚÅÊÒ, ×ÒÎÁÛ ÇÀÊĞÛÒÜ ÎÊÍÎ.  
    }

    public void ClosePanel()
    {
        Close();
    }

    public void OnPointerOpenPan()
    {
        //Ïåğåìåùàåì íàø îáúåêò íà S ğàññòîÿíèå ïî îñè x.
        if (i == 0)
        {
            transform.Translate(S, 0, 0);
            i = 1;
        }
        else if (i == 1)
        {
            transform.Translate(-S, 0, 0);
            i = 0;
        }

    }
}
