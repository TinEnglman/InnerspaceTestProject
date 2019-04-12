using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadingManager
{
    private const string _enterLiftKey = "ENTER_LIFT";
    private const string _loadingStartedKey = "LOADING_STARTED";
    private const string _loadingDoneKey = "LOADING_DONE";
    private const string _hintKeyPrefix = "HINT_";

    private int _numHints;
    private static LoadingManager _instance;

    public int CurrentHintIndex { get; set; }
    public ISceneLoader SceneLoader { get; set; }

    public string EnterLiftKey
    {
        get { return _enterLiftKey; }
    }

    public string LoadingStartedKey
    {
        get { return _loadingStartedKey; }
    }

    public string LoadingDoneKey
    {
        get { return _loadingDoneKey; }
    }

    public string HintKey
    {
        get { return HintKeyPrefix + ((CurrentHintIndex - 1) % _numHints + 1); }
    }

    public string HintKeyPrefix
    {
        get { return _hintKeyPrefix; }
    }

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

    public void Init(int numHints)
    {
        _numHints = numHints;
        CurrentHintIndex = (int)Random.Range(1, _numHints);
    }

    public void StartLoading(int sceneIndex)
    {
        SceneLoader.LoadScene(sceneIndex);
    }

    public float GetProgress()
    {
        return SceneLoader.Progress;
    }

    private LoadingManager() {}
}

