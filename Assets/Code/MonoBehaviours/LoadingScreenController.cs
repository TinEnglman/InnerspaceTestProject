using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LoadingScreenController : MonoBehaviour
{
    [SerializeField]
    private Slider _loadingSlider = null;
    [SerializeField]
    private TextMeshProUGUI _titleLabel = null;
    [SerializeField]
    private TextMeshProUGUI _hintLabel = null;

    private string _currentTitleTextKey;
    private string _currentHintTextKey;

    public void Init()
    {
        SetTitleTextKey(LoadingManager.Instance.EnterLiftKey);
        SetLableTextKey(LoadingManager.Instance.HintKey);
        _hintLabel.gameObject.SetActive(false);
        _loadingSlider.gameObject.SetActive(false);
        RefreshLabels();
    }

    void Update()
    {
        _loadingSlider.value = LoadingManager.Instance.GetProgress();
    }

    public void RefreshLabels()
    {
        _titleLabel.text = LocalizationManager.Instance.GetText(_currentTitleTextKey);
        _hintLabel.text = LocalizationManager.Instance.GetText(_currentHintTextKey);
    }

    public void SetTitleActive(bool active)
    {
        _titleLabel.gameObject.SetActive(active);
    }

    public void SetLabelActive(bool active)
    {
        _hintLabel.gameObject.SetActive(active);
    }

    public void StartLoading()
    {
        _hintLabel.gameObject.SetActive(true);
        _loadingSlider.gameObject.SetActive(true);
        SetTitleTextKey(LoadingManager.Instance.LoadingStartedKey);
        SetLableTextKey(LoadingManager.Instance.HintKey);
        RefreshLabels();
    }

    private void SetTitleTextKey(string textKey)
    {
        _currentTitleTextKey = textKey;
    }

    private void SetLableTextKey(string labelKey)
    {
        _currentHintTextKey = labelKey;
    }
}
