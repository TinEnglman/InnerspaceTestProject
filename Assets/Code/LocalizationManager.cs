using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocalizationManager
{
    private static LocalizationManager _instance;
    private Dictionary<string, string> _localizations = new Dictionary<string, string>();
 
    public ITextLoader TextLoader { get;  set; }

    public static LocalizationManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new LocalizationManager();
            }
            return _instance;
        }
    }

    public void LoadData()
    {
        Dictionary<string, string> addLocalizations = TextLoader.LoadText("LoadingScreen.json"); // create list
        
        foreach(var localization in addLocalizations)
        {
            _localizations.Add(localization.Key, localization.Value);
        }

        //_localizations[TextLoader.LoadedData.key] = TextLoader.LoadedData.localizedValue;
        //TextLoader.LoadText("Hints.json");
        //_localizations[TextLoader.LoadedData.key] = TextLoader.LoadedData.localizedValue;
    }

    public string GetText(string textKey)
    {
        return _localizations[textKey];
    }

    private LocalizationManager() { }
}
