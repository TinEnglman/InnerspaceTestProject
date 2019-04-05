using UnityEngine;

public class LiftController : MonoBehaviour
{
    [SerializeField]
    private int _sceneIndex;
    [SerializeField]
    private GameObject _frontWall;

    public ISceneLoader SceneLoader { get; set; }

    private void OnTriggerEnter(Collider other)
    {
        SceneLoader.LoadScene(_sceneIndex);
    }
}
