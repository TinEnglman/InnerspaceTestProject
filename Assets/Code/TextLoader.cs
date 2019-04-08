using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class TextLoader : ITextLoader
{
    public Dictionary<string, string> LoadText(string fileName)
    {
        string filePath = Application.dataPath + "/Texts/" + fileName;
        Dictionary<string, string> localizations = new Dictionary<string, string>();

        if (File.Exists(filePath))
        {
            string json = File.ReadAllText(filePath);
            LocalizationDataArray loadedData = LocalizationDataArray.CreateFromJSON(json);


            for (int i = 0; i < loadedData.keymap.Length; i++)
            {

                localizations.Add(loadedData.keymap[i].key, loadedData.keymap[i].localizedValue);
            }
        }
        return localizations;
    }
}
