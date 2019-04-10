using UnityEngine;

public class LiftEnterController : MonoBehaviour
{
    [SerializeField]
    private int _sceneIndex = 0;
    [SerializeField]
    private LoadingScreenController _loadingScreenController = null;

    public ISceneLoader SceneLoader { get; set; }

    private void OnTriggerEnter(Collider other)
    {
        _loadingScreenController.StartLoading();
        SceneLoader.LoadScene(_sceneIndex);
    }
}
