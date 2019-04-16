using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    [SerializeField]
    private string _textFolderName = "Texts";
    [SerializeField]
    private int _numHints = 0;
    [SerializeField]
    private LiftLoadingScreenController _loadingScreenController = null;
    [SerializeField]
    private CameraLoadingScreenController _cameraScreenController = null;

    void Start()
    {
        LocalizationManager.Instance.TextLoader = new TextLoader();
        LocalizationManager.Instance.LoadData(_textFolderName);

        LoadingManager.Instance.Init(_numHints);
        LoadingManager.Instance.SceneLoader = new SceneLoader();

        _loadingScreenController.Init(LoadingManager.Instance.EnterLiftKey, LoadingManager.Instance.HintKey);
        _cameraScreenController.Init(LoadingManager.Instance.EnterLiftKey, LoadingManager.Instance.HintKey);
    }
}
