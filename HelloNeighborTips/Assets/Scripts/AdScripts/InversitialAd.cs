using GoogleMobileAds.Api;
using System;
using UnityEngine;
using TMPro;

public class InversitialAd : MonoBehaviour
{
    private InterstitialAd _interstitial;

    private void Start()
    {
        RequestInterstitial();
        if (_interstitial.IsLoaded())
        {
            _interstitial.Show();
        }
    }

    private void RequestInterstitial()
    {
        string AdUnitId = "ca-app-pub-3238506285828195/4833676003";

        _interstitial = new InterstitialAd(AdUnitId);

        AdRequest request = new AdRequest.Builder().Build();
        _interstitial.LoadAd(request);
    }


}
