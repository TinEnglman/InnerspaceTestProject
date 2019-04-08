using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LoadingScreenController : MonoBehaviour
{
    [SerializeField]
    private Slider _loadingSlider = null;
    [SerializeField]
    private TextMeshProUGUI _titleLabel = null;

    public ISceneLoader SceneLoader { get; set; }

    void Start()
    {

    }

    void Update()
    {
        _loadingSlider.value = SceneLoader.Progress;
        _titleLabel.text = LocalizationManager.Instance.GetText("ENTER_LIFT");
    }
}
