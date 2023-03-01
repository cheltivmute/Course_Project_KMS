using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class PanelMainAnim : MonoBehaviour
{
    //������������� ���������� ������������ ��������� �����������.
    [SerializeField]
    public int S;
    public int i = 0;

    //����� ������� ����� ���������� �� ������� ����� ������.
    public void OnPointerOpen()
    {
        //���������� ��� ������ �� S ���������� �� ��� x.
        if (i == 0)
        {
            transform.Translate(S, 0, 0);
            i = 1;
        }         

    }

    public void OnPointerExit()
    {
        if (i == 1)
        {
            transform.Translate(-S, 0, 0);
            i = 0;
        }
        
    }

    public void Open()
    {
        gameObject.SetActive(true);
    }

    public void CloseMainPanel()
    {
        Close();
    }

    public void Close()
    {
        gameObject.SetActive(false);
    }

    public void OpenMainPanel()
    {
        Open();
        OnPointerExit();
    }
}