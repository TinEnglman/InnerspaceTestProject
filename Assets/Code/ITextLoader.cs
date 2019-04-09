using System.Collections.Generic;

public interface ITextLoader
{
    Dictionary<string, string> LoadText(string fileName);
}

