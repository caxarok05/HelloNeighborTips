using UnityEngine;
using System.Collections;
using System.Collections.Generic;
 
public class BtnSwitchLang : MonoBehaviour
{
    [SerializeField] private LocalizationManager localizationManager;

    public void OnButtonClick()
    {
        Debug.Log(localizationManager.CurrentLanguage);
        if (localizationManager.CurrentLanguage == "en_US")
        {
            localizationManager.CurrentLanguage = "ru_RU";
        }
        else if(localizationManager.CurrentLanguage == "ru_RU")
        {
            localizationManager.CurrentLanguage = "en_US";
        }
    }
}


