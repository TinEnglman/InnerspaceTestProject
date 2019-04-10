using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadingManager
{
    private static LoadingManager _instance;
    public int CurrentHintIndex { get; set; }

    public static LoadingManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new LoadingManager();
            }
            return _instance;
        }
    }

    private LoadingManager() {}
}

