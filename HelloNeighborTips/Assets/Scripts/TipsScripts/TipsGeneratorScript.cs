using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TipsGeneratorScript : MonoBehaviour
{
    public static int ActIndex = 0;

    public static List<GameObject> TipsButtonList = new List<GameObject>();
    public static int CurrentIndex = 0;

    [SerializeField] private GameObject _content;
    [SerializeField] private GameObject _tipPrefab;

    [SerializeField] private GameController _gameController;

    [SerializeField] private LocalizationManager _localizationManager;

    private GameObject _tip;

    private void Start()
    {
        TipsButtonList.Clear();
        SetTips();
    }
    private void SetTips()
    {

        for (int i = 0; i < _gameController._acts[ActIndex - 1].TipsList.Count; i++)
        {         
            _tip = Instantiate(_tipPrefab, _content.transform);
            TipsButtonList.Add(_tip);
            if (_localizationManager.CurrentLanguage == "ru_RU")
            {
                _tip.GetComponentInChildren<Text>().text = $"«¿Ã≈“ ¿  {i + 1}";
            }
            else if (_localizationManager.CurrentLanguage == "ru_RU")
            {
                _tip.GetComponentInChildren<Text>().text = $"TIP {i + 1}";
            }

            _tip.GetComponentInChildren<TipButtonScript>().TipIndex = i;
        }
    }
}
