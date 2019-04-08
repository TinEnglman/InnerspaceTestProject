using System.Collections.Generic;

public class LocalizationData
{
    public string Key { get; set; }
    public Dictionary<string, string> LocalizedValue = new Dictionary<string, string>();
}
