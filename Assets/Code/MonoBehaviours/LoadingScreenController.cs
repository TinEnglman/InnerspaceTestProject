using UnityEngine;
using UnityEngine.UI;

public class LoadingScreenController : MonoBehaviour
{
    [SerializeField]
    private Slider _loadingSlider = null; 
    public ISceneLoader SceneLoader { get; set; }

    void Update()
    {
        _loadingSlider.value = SceneLoader.Progress;
    }
}
