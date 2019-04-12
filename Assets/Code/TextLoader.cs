using System.Collections.Generic;
using System.IO;

public class TextLoader : ITextLoader
{
    public Dictionary<string, string> LoadText(string filePath)
    {
        Dictionary<string, string> localizations = new Dictionary<string, string>();

        if (File.Exists(filePath))
        {
            LocalizationDataArray loadedData = ParseFile(filePath);

            for (int i = 0; i < loadedData.keymap.Length; i++)
            {
                localizations.Add(loadedData.keymap[i].key, loadedData.keymap[i].localizedValue);
            }
        }

        return localizations;
    }

    private LocalizationDataArray ParseFile(string filePath)
    {
        string json = File.ReadAllText(filePath);
        LocalizationDataArray loadedData = LocalizationDataArray.CreateFromJSON(json);
        return loadedData;
    }
}
