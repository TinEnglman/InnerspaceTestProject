using UnityEngine;

public class LiftEnterController : MonoBehaviour
{
    [SerializeField]
    private int _sceneIndex = 0;

    public ISceneLoader SceneLoader { get; set; }

    private void OnTriggerEnter(Collider other)
    {
        SceneLoader.LoadScene(_sceneIndex);
    }
}
