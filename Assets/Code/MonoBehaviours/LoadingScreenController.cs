using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LoadingScreenController : ScreenController
{
    public void StartLoading()
    {
        _hintLabel.gameObject.SetActive(true);
        _loadingSlider.gameObject.SetActive(true);
        SetTitleTextKey(LoadingManager.Instance.LoadingStartedKey);
        SetLableTextKey(LoadingManager.Instance.HintKey);
        RefreshLabels();
    }
}
