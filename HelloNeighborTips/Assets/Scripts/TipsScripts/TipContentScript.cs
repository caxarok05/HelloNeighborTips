using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TipContentScript : MonoBehaviour
{
    [SerializeField] private Image _tipImage;
    [SerializeField] private Text _tipText;
    [SerializeField] private Text _tipName;

    [SerializeField] private GameObject _content;

    [SerializeField] private ContentSizeFitter _textSizeFitter;

    [SerializeField] private GameController _gameController;

    [SerializeField] private Font RussianFont;
    [SerializeField] private Font ForeighFont;

    private void Awake()
    {
        SetImage();
        SetText();

        _tipText.text = _gameController._acts[TipsGeneratorScript.ActIndex - 1].TipsList[TipsGeneratorScript.CurrentIndex].LocalizationIndex;
    }

    private void SetText()
    {
        _tipText.text = _gameController._acts[TipsGeneratorScript.ActIndex - 1].TipsList[TipsGeneratorScript.CurrentIndex].TipText;
        if (LocalizationManagerXML.SelectedLanguage == 1)
        {
            _tipName.text = $"янбер {TipsGeneratorScript.CurrentIndex + 1}";
            _tipName.font = RussianFont;
        }
        else if (LocalizationManagerXML.SelectedLanguage == 0)
        {
            _tipName.text = $"TIP {TipsGeneratorScript.CurrentIndex + 1}";
            _tipName.font = ForeighFont;
        }
        else if (LocalizationManagerXML.SelectedLanguage == 2)
        {
            _tipName.text = $"DICA {TipsGeneratorScript.CurrentIndex + 1}";
            _tipName.font = ForeighFont;
        }
        else if (LocalizationManagerXML.SelectedLanguage == 3)
        {
            _tipName.text = $"CONSEJO {TipsGeneratorScript.CurrentIndex + 1}";
            _tipName.font = ForeighFont;
        }


        CorrectText();

    }

    private void SetImage()
    {
        if (_gameController._acts[TipsGeneratorScript.ActIndex - 1].TipsList[TipsGeneratorScript.CurrentIndex].TipImage == null)
        {
            _tipImage.gameObject.SetActive(false);
        }
        else
        {
            _tipImage.sprite = _gameController._acts[TipsGeneratorScript.ActIndex - 1].TipsList[TipsGeneratorScript.CurrentIndex].TipImage;
            
        }
    }

    private void CorrectText()
    {
        _tipText.transform.SetParent(null);
        _textSizeFitter.enabled = true;
        _textSizeFitter.enabled = false;
        _tipText.transform.SetParent(_content.transform);
        _textSizeFitter.enabled = true;
    }
}
