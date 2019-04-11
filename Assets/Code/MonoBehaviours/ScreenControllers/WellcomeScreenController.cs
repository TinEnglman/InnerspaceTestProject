using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class WellcomeScreenController : ScreenController
{
    public void Hide()
    {
        _loadingSlider.gameObject.SetActive(false);
        _titleLabel.gameObject.SetActive(false);
        _hintLabel.gameObject.SetActive(false);
    }
}
