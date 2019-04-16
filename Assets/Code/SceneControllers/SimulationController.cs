using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimulationController : MonoBehaviour // extract "MenuController" ?
{
    [SerializeField]
    private string _textFolderName = "Texts";
    [SerializeField]
    private LiftLoadingScreenController _wellcomeScreenController = null;
    [SerializeField]
    private CameraLoadingScreenController _cameraScreenController = null;

    void Start()
    {
        if (LocalizationManager.Instance.TextLoader == null)
        {
            LocalizationManager.Instance.TextLoader = new TextLoader();
            LocalizationManager.Instance.LoadData(_textFolderName);
        }

        _wellcomeScreenController.Init(LoadingManager.Instance.LoadingDoneKey, LoadingManager.Instance.HintKey);
        _cameraScreenController.Init(LoadingManager.Instance.LoadingDoneKey, LoadingManager.Instance.HintKey);
    }
}
