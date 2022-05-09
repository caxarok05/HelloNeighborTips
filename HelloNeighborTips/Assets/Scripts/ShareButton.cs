using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class ShareButton : MonoBehaviour
{
    [TextArea(3, 10)]
    [SerializeField] private string _shareTextRus;

    [TextArea(3, 10)]
    [SerializeField] private string _shareTextEn;
    public void ShareButtonClick()
    {
        StartCoroutine(TakeSSAndShare());
    }

    private IEnumerator TakeSSAndShare()
    {
        yield return new WaitForEndOfFrame();

        if (LocalizationManagerXML.SelectedLanguage == 0)
        {
            new NativeShare().SetText(_shareTextEn).Share();
        }
        else if(LocalizationManagerXML.SelectedLanguage == 1)
        {
            new NativeShare().SetText(_shareTextRus).Share();
        }
    }
}