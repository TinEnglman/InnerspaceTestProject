using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ITextLoader
{
    LocalizationData LoadedData { get; set; }
    void LoadText(string fileName);
}

