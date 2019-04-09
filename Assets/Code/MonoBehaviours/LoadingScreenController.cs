using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LoadingScreenController : MonoBehaviour
{
   public ISceneLoader SceneLoader { get; set; }

    [SerializeField]
    private int _numHints = 1;
    [SerializeField]
    private Slider _loadingSlider = null;
    [SerializeField]
    private TextMeshProUGUI _titleLabel = null;
    [SerializeField]
    private TextMeshProUGUI _hintLabel = null;

    private int currentHintIndex = 1;

    void Start()
    {
        currentHintIndex = (int)Random.Range(1, _numHints);
    }

    void Update()
    {
        _loadingSlider.value = SceneLoader.Progress;
        _titleLabel.text = LocalizationManager.Instance.GetText("ENTER_LIFT");
        _hintLabel.text = LocalizationManager.Instance.GetText("HINT_" + currentHintIndex);
    }
}
