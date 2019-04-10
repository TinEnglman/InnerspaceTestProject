using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LoadingScreenController : MonoBehaviour
{
    public ISceneLoader SceneLoader { get; set; }

    private readonly string EnterLiftKey = "ENTER_LIFT";
    private readonly string LoadingStartedKey = "LOADING_STARTED";
    private readonly string HintKeyPrefix = "HINT_";

    [SerializeField]
    private int _numHints = 0;
    [SerializeField]
    private Slider _loadingSlider = null;
    [SerializeField]
    private TextMeshProUGUI _titleLabel = null;
    [SerializeField]
    private TextMeshProUGUI _hintLabel = null;

    private string _currentTitleTextKey;
    private string _currentHintTextKey;

    void Start()
    {
        LoadingManager.Instance.CurrentHintIndex = (int)Random.Range(1, _numHints);
        SetTitleTextKey(EnterLiftKey);
        _currentHintTextKey = HintKeyPrefix + LoadingManager.Instance.CurrentHintIndex;
        _hintLabel.gameObject.SetActive(false);
        _loadingSlider.gameObject.SetActive(false);
    }

    void Update()
    {
        _loadingSlider.value = SceneLoader.Progress;
    }

    public void RefreshLabels()
    {
        _titleLabel.text = LocalizationManager.Instance.GetText(_currentTitleTextKey);
        _hintLabel.text = LocalizationManager.Instance.GetText(_currentHintTextKey);
    }

    public void StartLoading()
    {
        _hintLabel.gameObject.SetActive(true);
        _loadingSlider.gameObject.SetActive(true);
        SetTitleTextKey(LoadingStartedKey);
        SetLableTextKey(LoadingManager.Instance.CurrentHintIndex);
        RefreshLabels();
    }

    private void SetTitleTextKey(string textKey)
    {
        _currentTitleTextKey = textKey;
    }

    private void SetLableTextKey(int index)
    {
        _currentHintTextKey = HintKeyPrefix + ((index - 1) % _numHints + 1);
    }
}
