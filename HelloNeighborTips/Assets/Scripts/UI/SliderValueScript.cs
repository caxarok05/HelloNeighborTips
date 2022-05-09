using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderValueScript : MonoBehaviour
{
    private Slider _slider;
    private Text _text;

    private void Awake()
    {
        _text = GetComponentInChildren<Text>();
        _slider = GetComponent<Slider>();
    }

    public void ShowSliderValue()
    {
        if (_slider.value == 6)
        {
            _text.text = "<" + _slider.value.ToString();
        }
        else if(_slider.value == 65)
        {
            _text.text =  _slider.value.ToString() + "+";
        }
        else
        {
            _text.text = _slider.value.ToString();
        }

    }
}
