using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class WellcomeScreenController : MonoBehaviour
{
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
        SetTitleTextKey(LoadingManager.Instance.LoadingDoneKey);
        SetLableTextKey(LoadingManager.Instance.HintKey);
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

    private void SetLableTextKey(string textKey)
    {
        _currentHintTextKey = textKey;
    }
}
