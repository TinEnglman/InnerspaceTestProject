using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class WellcomeScreenController : MonoBehaviour
{
    private readonly string LoadingDoneKey = "LOADING_DONE";
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
        SetTitleTextKey(LoadingDoneKey);
        SetLableTextKey(LoadingManager.Instance.CurrentHintIndex);
        _loadingSlider.value = 1;
        RefreshLabels();
    }

    public void RefreshLabels()
    {
        _titleLabel.text = LocalizationManager.Instance.GetText(_currentTitleTextKey);
        _hintLabel.text = LocalizationManager.Instance.GetText(_currentHintTextKey);
    }

    public void Hide()
    {
        _loadingSlider.gameObject.SetActive(false);
        _titleLabel.gameObject.SetActive(false);
        _hintLabel.gameObject.SetActive(false);
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
