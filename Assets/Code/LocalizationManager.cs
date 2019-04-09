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

    public string GetText(string textKey)
    {
        return _localizations[textKey];
    }

    public void LoadData(string folderName)
    {
        DirectoryInfo info = new DirectoryInfo(Application.dataPath + "/" + folderName);
        var fileInfo = info.GetFiles();

        foreach (var file in fileInfo)
        {
            Dictionary<string, string> addLocalizations = LoadFile(file);
            AddLocalizations(addLocalizations);
        }
    }

    private Dictionary<string, string> LoadFile(FileInfo file)
    {
        Dictionary<string, string> localizations = new Dictionary<string, string>();
        if (file.Extension == ".json")
        {
            localizations = TextLoader.LoadText(file.FullName);
        }
        return localizations;
    }

    private void AddLocalizations(Dictionary<string, string> addLocalizations)
    {
        foreach (var localization in addLocalizations)
        {
            _localizations.Add(localization.Key, localization.Value);
        }
    }
    
    private LocalizationManager() { }
}
