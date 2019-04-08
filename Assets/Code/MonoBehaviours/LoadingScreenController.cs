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
        _titleLabel.text = LocalizationManager.getText("ENTER_LIFT");
    }

    void Update()
    {
        _loadingSlider.value = SceneLoader.Progress;
    }
}
