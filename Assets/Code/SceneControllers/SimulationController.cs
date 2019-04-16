using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimulationController : MonoBehaviour // extract "MenuController" ?
{
    private const string InputKeystateEscape = "escape";

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

        if (LoadingManager.Instance.SceneLoader == null)
        {
            LoadingManager.Instance.Init(1);
            LoadingManager.Instance.SceneLoader = new SceneLoader();
        }

        _wellcomeScreenController.Init(LoadingManager.Instance.LoadingDoneKey, LoadingManager.Instance.HintKey);
        _cameraScreenController.Init(LoadingManager.Instance.LoadingDoneKey, LoadingManager.Instance.HintKey);
        _cameraScreenController.ScreenScaler = new ScreenScalerDmm();
        _cameraScreenController.SetupScale();
    }

    void Update()
    {
        if (Input.GetKeyDown(InputKeystateEscape)) // move to separate module
        {
            Cursor.lockState = CursorLockMode.None;
            Application.Quit();
        }
    }
}
