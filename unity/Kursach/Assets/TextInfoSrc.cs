using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextInfoSrc : MonoBehaviour
{
    [SerializeField]
    Text message;
    public void WtiteText1()
    {   //  �����, ���������� ������������� ������� �� ������ 
        message.text = "����������� ����. ��������������, ����� �������� ����� 0,960 ��";
    }
    public void WtiteText2()
    {   //  �����, ���������� ������������� ������� �� ������ 
        message.text = "��������� �����, � ������� ������� ������������ ���������� ����";
    }
    public void WtiteText3()
    {   //  �����, ���������� ������������� ������� �� ������ 
        message.text = "�����";
    }
    public void WtiteText4()
    {   //  �����, ���������� ������������� ������� �� ������ 
        message.text = "������������ ���������, �� ������� ��������� �����";
    }
    public void WtiteText5()
    {   //  �����, ���������� ������������� ������� �� ������ 
        message.text = "��� ����������, ����� �������� �������� ������������ ���������";
    }
    public void WtiteText6()
    {   //  �����, ���������� ������������� ������� �� ������ 
        message.text = "������ ���������";
    }
    public void WtiteText7()
    {   //  �����, ���������� ������������� ������� �� ������ 
        message.text = "�������������, ������� ��������� ����� � ����������� �� ���� f0 ���������";
    }
    public void WtiteText8()
    {   //  �����, ���������� ������������� ������� �� ������ 
        message.text = "�����, �� ������� ������������ ���� ����������";
    }
    public void WtiteText9()
    {   //  �����, ���������� ������������� ������� �� ������ 
        message.text = "����������������� ������, ������� ������������ ������� ����� N ��������� �����";
    }
    public void WtiteText10()
    {   //  �����, ���������� ������������� ������� �� ������ 
        message.text = "�������� ������� ����� ��������� � ����������";
    }
    public void WtiteTextStart()
    {   //  �����, ���������� ������������� ������� �� ������ 
        message.text = "������ ����";
    }
    public void WtiteTextNone()
    {   //  �����, ���������� ������������� ������� �� ������ 
        message.text = "�������������� ������";
    }

    public void TextEnabled()
    {
        transform.gameObject.SetActive(true);
    }

    public void TextDisabled()
    {
        transform.gameObject.SetActive(false);
    }
}
