using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{

    private void Start()
    {
        Screen.fullScreen = false;
    }

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
        TipsGeneratorScript.ActIndex = index;
    }

    public void NextIndex()
    {
        TipsGeneratorScript.CurrentIndex += 1;
    }

    public void RefreshScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


}
