using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextInfoSrc : MonoBehaviour
{
    [SerializeField]
    Text message;
    public void WtiteText1()
    {   //  МЕТОД, ВЫЗЫВАЕМЫЙ ПОЛЬЗОВАТЕЛЕМ ЩЕЛЧКОМ ПО КНОПКЕ 
        message.text = "исследуемое тело. Параллелепипед, масса которого равна 0,960 кг";
    }
    public void WtiteText2()
    {   //  МЕТОД, ВЫЗЫВАЕМЫЙ ПОЛЬЗОВАТЕЛЕМ ЩЕЛЧКОМ ПО КНОПКЕ 
        message.text = "подвижная балка, с помоцью которой закрепляется исседуемое тело";
    }
    public void WtiteText3()
    {   //  МЕТОД, ВЫЗЫВАЕМЫЙ ПОЛЬЗОВАТЕЛЕМ ЩЕЛЧКОМ ПО КНОПКЕ 
        message.text = "рамка";
    }
    public void WtiteText4()
    {   //  МЕТОД, ВЫЗЫВАЕМЫЙ ПОЛЬЗОВАТЕЛЕМ ЩЕЛЧКОМ ПО КНОПКЕ 
        message.text = "вертикальная проволока, на которой подвешена рамка";
    }
    public void WtiteText5()
    {   //  МЕТОД, ВЫЗЫВАЕМЫЙ ПОЛЬЗОВАТЕЛЕМ ЩЕЛЧКОМ ПО КНОПКЕ 
        message.text = "два кронштейна, между которыми натянута вертикальная проволока";
    }
    public void WtiteText6()
    {   //  МЕТОД, ВЫЗЫВАЕМЫЙ ПОЛЬЗОВАТЕЛЕМ ЩЕЛЧКОМ ПО КНОПКЕ 
        message.text = "стойка установки";
    }
    public void WtiteText7()
    {   //  МЕТОД, ВЫЗЫВАЕМЫЙ ПОЛЬЗОВАТЕЛЕМ ЩЕЛЧКОМ ПО КНОПКЕ 
        message.text = "электромагнит, который фиксирует рамку в отклоненном на угол f0 положении";
    }
    public void WtiteText8()
    {   //  МЕТОД, ВЫЗЫВАЕМЫЙ ПОЛЬЗОВАТЕЛЕМ ЩЕЛЧКОМ ПО КНОПКЕ 
        message.text = "шкала, по которой определяется угол отклонения";
    }
    public void WtiteText9()
    {   //  МЕТОД, ВЫЗЫВАЕМЫЙ ПОЛЬЗОВАТЕЛЕМ ЩЕЛЧКОМ ПО КНОПКЕ 
        message.text = "фотоэлектрический датчик, который осуществляет подсчет числа N колебаний рамки";
    }
    public void WtiteText10()
    {   //  МЕТОД, ВЫЗЫВАЕМЫЙ ПОЛЬЗОВАТЕЛЕМ ЩЕЛЧКОМ ПО КНОПКЕ 
        message.text = "цифровой счетчик числа колебаний и секундомер";
    }
    public void WtiteTextStart()
    {   //  МЕТОД, ВЫЗЫВАЕМЫЙ ПОЛЬЗОВАТЕЛЕМ ЩЕЛЧКОМ ПО КНОПКЕ 
        message.text = "кнопка пуск";
    }
    public void WtiteTextNone()
    {   //  МЕТОД, ВЫЗЫВАЕМЫЙ ПОЛЬЗОВАТЕЛЕМ ЩЕЛЧКОМ ПО КНОПКЕ 
        message.text = "информационная панель";
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
