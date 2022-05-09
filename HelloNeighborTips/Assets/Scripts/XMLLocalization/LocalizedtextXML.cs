using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[RequireComponent(typeof(Text))]
public class LocalizedtextXML : MonoBehaviour
{
    private LocalizationManagerXML _localizationManagerXML;
    private Text _text;
    private string _key;

    public void Localize(string newKey = null)
    {
        if (_text == null)
            Init();

        if (newKey != null)
            _key = newKey;

        _text.text = LocalizationManagerXML.GetTranslate(_key);

    }
  
    private void Start()
    {
        _localizationManagerXML = GameObject.FindGameObjectWithTag("LocalizationManager").GetComponent<LocalizationManagerXML>();
        Localize();
        LocalizationManagerXML.OnLanguageChanged += OnLanguageChange;
    }

    private void OnLanguageChange()
    {
        Localize();
    }

    private void OnDestroy()
    {
        LocalizationManagerXML.OnLanguageChanged -= OnLanguageChange;
    }

    private void Init()
    {
        _text = GetComponent<Text>();
        _key = _text.text;
        if (LocalizationManagerXML.SelectedLanguage == 0)
        {
            _text.font = _localizationManagerXML.EnglishFont;
        }
        if (LocalizationManagerXML.SelectedLanguage == 1)
        {
            _text.font = _localizationManagerXML.RussianFont;
        }
    }
}
