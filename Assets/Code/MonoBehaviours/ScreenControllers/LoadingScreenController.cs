using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LoadingScreenController : ScreenController
{
    public override void Init(string initialTitleTextKey, string initialHintTextKey)
    {
        base.Init(initialTitleTextKey, initialHintTextKey);
        _loadingSlider.gameObject.SetActive(false);
        _hintLabel.gameObject.SetActive(false);

    }

    public void StartLoading()
    {
        _hintLabel.gameObject.SetActive(true);
        _loadingSlider.gameObject.SetActive(true);
        SetTitleTextKey(LoadingManager.Instance.LoadingStartedKey);
        SetLableTextKey(LoadingManager.Instance.HintKey);
        RefreshLabels();
    }
}
