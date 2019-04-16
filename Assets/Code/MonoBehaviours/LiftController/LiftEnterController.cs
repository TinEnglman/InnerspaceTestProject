using UnityEngine;

public class LiftEnterController : MonoBehaviour
{
    [SerializeField]
    private int _sceneIndex = 0;
    [SerializeField]
    private LiftLoadingScreenController _loadingScreenController = null;
    [SerializeField]
    private CameraLoadingScreenController _cameraScreenController = null;

    private void OnTriggerEnter(Collider other)
    {
        LoadingManager.Instance.StartLoading(_sceneIndex);
        _loadingScreenController.DisplayLoading();
        _cameraScreenController.DisplayLoading();
    }
}
