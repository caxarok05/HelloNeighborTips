using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NextButtonScript : MonoBehaviour
{
    [SerializeField] private Button _nextButton;

    private void Update()
    {
        if (TipsGeneratorScript.CurrentIndex + 1 >= TipsGeneratorScript.TipsButtonList.Count)
        {

            _nextButton.interactable = false;
        }
        
    }
}
