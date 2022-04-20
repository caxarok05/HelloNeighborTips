using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public void ChangeScene(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }

    public void OpenURL(string URL)
    {
        Application.OpenURL(URL);
    }

    public void ChangeCurrentAct(int index)
    {
        TipCountScript._actIndex = index;
    }

}
