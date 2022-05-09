using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GameController", menuName = "ScriptableObjects/GameController", order = 51)]
public class GameController : ScriptableObject
{
    [Header ("")]
    public Act[] _acts = new Act[3];
}
