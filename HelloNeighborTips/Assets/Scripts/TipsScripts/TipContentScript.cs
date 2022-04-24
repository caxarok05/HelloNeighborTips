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
    [SerializeField] private VerticalLayoutGroup _verticalLayotGroup;

    [SerializeField] private GameController _gameController;

    [SerializeField] private LocalizationManager _localizationManager;

    private void Awake()
    {
        SetImage();
        SetText();

        _tipText.GetComponent<LocalizedText>().key = _gameController._acts[TipsGeneratorScript.ActIndex - 1].TipsList[TipsGeneratorScript.CurrentIndex].LocalizationIndex;

    }

    private void SetText()
    {
        _tipText.text = _gameController._acts[TipsGeneratorScript.ActIndex - 1].TipsList[TipsGeneratorScript.CurrentIndex].TipText;
        if (_localizationManager.CurrentLanguage == "ru_RU")
        {
            _tipName.text = $"«¿Ã≈“ ¿  {TipsGeneratorScript.CurrentIndex + 1}";
        }
        else if (_localizationManager.CurrentLanguage == "ru_RU")
        {
            _tipName.text = $"TIP {TipsGeneratorScript.CurrentIndex + 1}";
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
