using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class LocalizationManager
{
    public ITextLoader TextLoader { get; set; }

    private static LocalizationManager _instance;
    private Dictionary<string, string> _localizations = new Dictionary<string, string>();
 
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

    public string FolderName { get; set; }

    public void LoadData()
    {
        DirectoryInfo info = new DirectoryInfo(Application.dataPath + "/" + FolderName);
        var fileInfo = info.GetFiles();

        foreach (var file in fileInfo)
        {
            if (file.Extension == ".json")
            { 
                Dictionary<string, string> addLocalizations = TextLoader.LoadText(file.FullName);
                foreach (var localization in addLocalizations)
                {
                    _localizations.Add(localization.Key, localization.Value);
                }
            }
        }
    }

    public string GetText(string textKey)
    {
        return _localizations[textKey];
    }

    private LocalizationManager() { }
}
