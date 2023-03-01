using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textZnach : MonoBehaviour
{
    [SerializeField]
    public Slider slider;
    public Text message;
    public void OnSliderValueChanged()
    {
        message.text = slider.value.ToString();
    }
}
