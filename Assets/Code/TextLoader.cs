using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class TextLoader : ITextLoader
{
    public LocalizationData LoadedData { get; set; }

    public void LoadText(string fileName)
    {
        string filePath = Application.dataPath + "/Texts/" + fileName;

        if (File.Exists(filePath))
        {
            string dataAsJson = File.ReadAllText(filePath);
            LoadedData = JsonUtility.FromJson<LocalizationData>(dataAsJson);
        }
    }
}
