using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipButtonScript : MonoBehaviour
{
    [HideInInspector]
    public int TipIndex;

    public void SetIndex()
    {
        TipsGeneratorScript.CurrentIndex = TipIndex;
    }

}
