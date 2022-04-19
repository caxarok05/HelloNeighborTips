using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrivacyPolicyButton : MonoBehaviour
{
    [SerializeField] private Button _nextButton;
    [SerializeField] private Toggle _agreementToggle;

    private string _privacyPolicykey = "PrivacyPolicykey";
    

    private void Awake()
    {
        if (PlayerPrefs.HasKey(_privacyPolicykey))
        {
            gameObject.SetActive(false);
        }
    }

    public void AgreeToPolicy()
    {
        PlayerPrefs.SetString(_privacyPolicykey, "PlayerAgreesPolicy");
        gameObject.SetActive(false);
    }

    public void OnOffButton(Button button)
    {
        button.interactable = !button.IsInteractable();
    }
}
