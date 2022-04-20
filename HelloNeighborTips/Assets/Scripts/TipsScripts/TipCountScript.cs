using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TipCountScript : MonoBehaviour
{
    [SerializeField] private GameObject _content;
    [SerializeField] private int _tipsCount;
    public static int _actIndex; 
    [SerializeField] private GameObject _tipPrefab;

    [SerializeField] private GameController _gameController;

    private void Awake()
    {
        SetTips();
    }
    private void SetTips()
    {
        //if (_content.transform.childCount > 0)
        //{
        //    for (int i = 0; i < _content.transform.childCount; i++)
        //    {
        //        Destroy(_content.transform.GetChild(i).gameObject);
        //    }

        //}
        for (int i = 0; i < _gameController._acts[_actIndex - 1].TipsList.Count; i++)
        {
            _tipPrefab.GetComponentInChildren<Text>().text = $"TIP {i + 1}";
            Instantiate(_tipPrefab, _content.transform);
            
        }
    }
}
