using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScreenController : MonoBehaviour
{
    [SerializeField]
    protected Slider _loadingSlider = null;
    [SerializeField]
    protected TextMeshProUGUI _titleLabel = null;
    [SerializeField]
    protected TextMeshProUGUI _hintLabel = null;

    private string _currentTitleTextKey;
    private string _currentHintTextKey;

    public virtual void Init(string initialTitleTextKey, string initialHintTextKey)
    {
        SetTitleTextKey(initialTitleTextKey);
        SetLableTextKey(initialHintTextKey);
        RefreshLabels();
    }

    public virtual void Update()
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

    protected void SetTitleTextKey(string textKey)
    {
        _currentTitleTextKey = textKey;
    }

    protected void SetLableTextKey(string labelKey)
    {
        _currentHintTextKey = labelKey;
    }
}
