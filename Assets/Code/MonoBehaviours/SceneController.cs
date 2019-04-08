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
        LocalizationManager localizationManager = new LocalizationManager();
        localizationManager.TextLoader = new TextLoader();
        localizationManager.LoadData();


        ISceneLoader sceneLoader = new SceneLoader();
        _liftController.SceneLoader = sceneLoader;
        _loadingScreenController.SceneLoader = sceneLoader;
    }
}
