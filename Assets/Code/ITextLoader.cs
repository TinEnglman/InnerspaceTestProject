using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ITextLoader
{
    Dictionary<string, string> LoadText(string fileName);
}

