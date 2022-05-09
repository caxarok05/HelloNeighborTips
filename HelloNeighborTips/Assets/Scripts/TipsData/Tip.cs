using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Tip 
{
    [Header ("TIP")]
    public Sprite TipImage;

    [HideInInspector]
    public string TipText;

    [TextArea(2, 10)]
    public string LocalizationIndex;
}
