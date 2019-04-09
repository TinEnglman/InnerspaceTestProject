using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    [SerializeField]
    private string _textFolderName = "Texts";
    [SerializeField]
    private LiftController _liftController = null;
    [SerializeField]
    private LoadingScreenController _loadingScreenController = null;

    void Start()
    {
        LocalizationManager.Instance.TextLoader = new TextLoader();
        LocalizationManager.Instance.LoadData(_textFolderName);

        ISceneLoader sceneLoader = new SceneLoader();
        _liftController.SceneLoader = sceneLoader;
        _loadingScreenController.SceneLoader = sceneLoader;
    }
}
