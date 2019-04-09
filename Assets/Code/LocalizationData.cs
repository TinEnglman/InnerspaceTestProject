using UnityEngine;

[System.Serializable]
public class LocalizationData
{
    public string key;
    public string localizedValue;

    public static LocalizationData CreateFromJSON(string jsonString)
    {
        return JsonUtility.FromJson<LocalizationData>(jsonString);
    }
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


