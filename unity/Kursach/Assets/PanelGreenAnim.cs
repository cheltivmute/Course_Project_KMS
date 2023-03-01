using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelGreenAnim : MonoBehaviour
{
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
}
