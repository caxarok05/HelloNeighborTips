using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;

public class LocalizationManagerXML : MonoBehaviour
{
    public static int SelectedLanguage { get; set; }

    public static event LanguageChangeHandler OnLanguageChanged;
    public delegate void LanguageChangeHandler();

    public Font RussianFont;
    public Font ForeighFont;

    [SerializeField] private TextAsset _textFile;

    private static Dictionary<string, List<string>> _localization;

    public static string GetTranslate(string key, int languageId = -1)
    {
        if (languageId == -1)
            languageId = SelectedLanguage;

        if (_localization.ContainsKey(key))
            return _localization[key][languageId];

        return key;
    }

    public void SetLanguage(int id)
    {
        SelectedLanguage = id;
        PlayerPrefs.SetInt("Localization", SelectedLanguage);
        OnLanguageChanged?.Invoke();
    }

    private void Awake()
    {
       
        if (PlayerPrefs.HasKey("Localization"))
        {
            SelectedLanguage = PlayerPrefs.GetInt("Localization");
        }
        if (_localization == null && (Application.systemLanguage.ToString() == SystemLanguage.Russian.ToString() ||
            Application.systemLanguage.ToString() == SystemLanguage.Belarusian.ToString() ||
            Application.systemLanguage.ToString() == SystemLanguage.Ukrainian.ToString()) && !PlayerPrefs.HasKey("PrivacyPolicykey"))
        {
            SelectedLanguage = 1;
            LoadLocalization();
        }
        if (_localization == null && Application.systemLanguage.ToString() == SystemLanguage.English.ToString() && !PlayerPrefs.HasKey("PrivacyPolicykey"))
        {
            SelectedLanguage = 0;
            LoadLocalization();
        }
        if (_localization == null && Application.systemLanguage.ToString() == SystemLanguage.Portuguese.ToString() && PlayerPrefs.HasKey("PrivacyPolicykey"))
        {
            SelectedLanguage = 2;
            LoadLocalization();
        }
        if (_localization == null && Application.systemLanguage.ToString() == SystemLanguage.Spanish.ToString() && PlayerPrefs.HasKey("PrivacyPolicykey"))
        {
            SelectedLanguage = 3;
            LoadLocalization();
        }
        if (_localization == null)
            LoadLocalization();
    }

    private void LoadLocalization()
    {
        _localization = new Dictionary<string, List<string>>();

        XmlDocument xmlDocument = new XmlDocument();
        xmlDocument.LoadXml(_textFile.text);

        foreach (XmlNode key in xmlDocument["Keys"].ChildNodes)
        {
            string keyStr = key.Attributes["Name"].Value;

            var values = new List<string>();
            foreach (XmlNode translate in key["Translates"].ChildNodes)
                values.Add(translate.InnerText);

            _localization[keyStr] = values;       
        }
    }
}
