using UnityEngine;
using GoogleMobileAds.Api;
using System;

public class GoogleMobileAdsDemoScript : MonoBehaviour
{
    private static bool IsFirstLaunch;

    public void Start()
    {
        // Load an app open ad when the scene starts
        AppOpenAd.Instance.LoadAd();

        if (PlayerPrefs.HasKey("PrivacyPolicykey") && IsFirstLaunch == false)
        {
            AppOpenAd.Instance.ShowAdIfAvailable();
            IsFirstLaunch = true;
        }
        
    }
    public void NotFirstLaunch()
    {
        IsFirstLaunch = true;
    }

    public void OnApplicationPause(bool paused)
    {
        // Display the app open ad when the app is foregrounded
        if (!paused)
        {
            AppOpenAd.Instance.ShowAdIfAvailable();
        }
    }
}
