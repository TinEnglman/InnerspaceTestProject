using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocalizationManager // turn to singleton
{
    public ITextLoader TextLoader { get;  set; }

    private static Dictionary<string, string> _localizations = new Dictionary<string, string>();

    public void LoadData()
    {
        TextLoader.LoadText("LoadingScreen.json"); // create list
        _localizations[TextLoader.LoadedData.Key] = TextLoader.LoadedData.LocalizedValue["en - US"];
        TextLoader.LoadText("Hints.json");
        _localizations[TextLoader.LoadedData.Key] = TextLoader.LoadedData.LocalizedValue["en - US"];
    }

    public static string getText(string textKey)
    {
        return _localizations[textKey];
    }
}
