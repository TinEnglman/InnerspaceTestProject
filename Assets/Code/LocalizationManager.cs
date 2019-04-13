using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class LocalizationManager
{
    private const string ErrorMessagePrefix = "Text Key: '";
    private const string ErrorMessageSufix = "' does not exist!";
    public ITextLoader TextLoader { get; set; }

    private static LocalizationManager _instance;
    private Dictionary<string, string> _localizations;
 
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
        if (_localizations.ContainsKey(textKey))
        {
            return _localizations[textKey];
        }
        else
        {
            return ErrorMessagePrefix + textKey + ErrorMessageSufix;
        }
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

    public void ClearData()
    {
        _localizations.Clear();
    }

    public void AddLocalizations(Dictionary<string, string> addLocalizations)
    {
        foreach (var localization in addLocalizations)
        {
            _localizations.Add(localization.Key, localization.Value);
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
    
    private LocalizationManager()
    {
        _localizations = new Dictionary<string, string>();
    }
}
