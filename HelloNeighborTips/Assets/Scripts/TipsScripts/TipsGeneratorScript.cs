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

    [SerializeField] private Font RussianFont;
    [SerializeField] private Font EnglishFont;

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
            if (LocalizationManagerXML.SelectedLanguage == 1)
            {
                _tip.GetComponentInChildren<Text>().text = $"янбер  {i + 1}";
                _tip.GetComponentInChildren<Text>().font = RussianFont;
            }
            else if (LocalizationManagerXML.SelectedLanguage == 0)
            {
                _tip.GetComponentInChildren<Text>().text = $"TIP {i + 1}";
                _tip.GetComponentInChildren<Text>().font = EnglishFont;
            }

            _tip.GetComponentInChildren<TipButtonScript>().TipIndex = i;
        }
    }
}
