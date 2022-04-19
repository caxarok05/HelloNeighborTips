using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderValueScript : MonoBehaviour
{
    private Slider _slider;
    private Text _text;

    void Awake()
    {
        _text = GetComponentInChildren<Text>();
        _slider = GetComponent<Slider>();
    }

    public void ShowSliderValue()
    {
        _text.text = _slider.value.ToString();
    }
}
