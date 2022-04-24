using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Tip 
{
    public Sprite TipImage;

    [TextArea (10, 10)]
    public string TipText;
    [TextArea(1, 10)]
    public string LocalizationIndex;
}
