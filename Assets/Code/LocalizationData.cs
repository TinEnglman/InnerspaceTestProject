using UnityEngine;

[System.Serializable]
public class LocalizationData
{
    public string key;
    public string localizedValue;
}

[System.Serializable]
public class LocalizationDataArray
{
    public LocalizationData[] keymap;

    public static LocalizationDataArray CreateFromJSON(string jsonString)
    {
        return JsonUtility.FromJson<LocalizationDataArray>(jsonString);
    }
}


