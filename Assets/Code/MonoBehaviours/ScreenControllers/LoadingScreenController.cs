using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LoadingScreenController : MonoBehaviour
{
    private string _currentTitleTextKey;
    private string _currentHintTextKey;

    public Slider LoadingSlider { get; set; }
    public TextMeshProUGUI TitleLabel { get; set; }
    public TextMeshProUGUI HintLabel { get; set; }

    public virtual void Init(string initialTitleTextKey, string initialHintTextKey)
    {
        SetTitleTextKey(initialTitleTextKey);
        SetLableTextKey(initialHintTextKey);
    }

    public virtual void Update()
    {
        LoadingSlider.value = LoadingManager.Instance.GetProgress();
    }

    public void SetTitleActive(bool active)
    {
        TitleLabel.gameObject.SetActive(active);
    }

    public void SetLabelActive(bool active)
    {
        HintLabel.gameObject.SetActive(active);
    }

    public void SetTitleTextKey(string textKey)
    {
        _currentTitleTextKey = textKey;
    }

    public void SetLableTextKey(string labelKey)
    {
        _currentHintTextKey = labelKey;
    }

    public void Hide()
    {
        LoadingSlider.gameObject.SetActive(false);
        TitleLabel.gameObject.SetActive(false);
        HintLabel.gameObject.SetActive(false);
    }

    public void RefreshLabels()
    {
        TitleLabel.text = LocalizationManager.Instance.GetText(_currentTitleTextKey);
        HintLabel.text = LocalizationManager.Instance.GetText(_currentHintTextKey);
    }

    public void DisplayLoading()
    {
        HintLabel.gameObject.SetActive(true);
        LoadingSlider.gameObject.SetActive(true);
        SetTitleTextKey(LoadingManager.Instance.LoadingStartedKey);
        SetLableTextKey(LoadingManager.Instance.HintKey);
        RefreshLabels();
    }
}
