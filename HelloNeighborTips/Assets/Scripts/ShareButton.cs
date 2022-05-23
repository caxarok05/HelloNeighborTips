using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class ShareButton : MonoBehaviour
{
    [TextArea(3, 12)]
    [SerializeField] private string _shareTextRus;

    [TextArea(3, 12)]
    [SerializeField] private string _shareTextEn;

    [TextArea(3, 12)]
    [SerializeField] private string _shareTextEs;

    [TextArea(3, 12)]
    [SerializeField] private string _shareTextPt;

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
        else if (LocalizationManagerXML.SelectedLanguage == 2)
        {
            new NativeShare().SetText(_shareTextPt).Share();
        }
        else if (LocalizationManagerXML.SelectedLanguage == 3)
        {
            new NativeShare().SetText(_shareTextEs).Share();
        }

    }
}