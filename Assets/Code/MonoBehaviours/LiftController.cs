using UnityEngine;

public class LiftController : MonoBehaviour
{
    [SerializeField]
    private int _sceneIndex = 0;
    [SerializeField]
    private DoorController _liftDoor = null;
    
    public ISceneLoader SceneLoader { get; set; }

    private void OnTriggerEnter(Collider other)
    {
        //SceneLoader.LoadScene(_sceneIndex);
        _liftDoor.SetOpen(false);
    }
}
