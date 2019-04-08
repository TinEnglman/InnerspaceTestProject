using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    [SerializeField]
    private LiftController _liftController;
    [SerializeField]
    private LoadingScreenController _loadingScreenController;

    void Start()
    {
        LocalizationManager.Instance.TextLoader = new TextLoader();
        LocalizationManager.Instance.LoadData();

        ISceneLoader sceneLoader = new SceneLoader();
        _liftController.SceneLoader = sceneLoader;
        _loadingScreenController.SceneLoader = sceneLoader;
    }
}
