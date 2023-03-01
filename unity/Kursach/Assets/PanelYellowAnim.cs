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
        Close(); //  ������� ����������� ���� ��� ������� ���������  
    }

    public void OnOpenSettings()
    {
        Open();  //  ������� ����������� ��������� ���� 
    }

    public void Open()
    {
        gameObject.SetActive(true); //   ������������ ������, ����� ������� ����.  
    }

    public void Close()
    {
        gameObject.SetActive(false); // �������������� ������, ����� ������� ����.  
    }

    public void ClosePanel()
    {
        Close();
    }

    public void OnPointerOpenPan()
    {
        //���������� ��� ������ �� S ���������� �� ��� x.
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
