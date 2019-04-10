using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class WellcomeScreenController : MonoBehaviour
{
    private readonly string LoadingDoneKey = "LOADING_DONE";

    [SerializeField]
    private Slider _loadingSlider = null;
    [SerializeField]
    private TextMeshProUGUI _titleLabel = null;

    private string _currentTitleTextKey;

    void Start()
    {
        SetTitleTextKey(LoadingDoneKey);
        _loadingSlider.value = 1;
    }

    public void RefreshLabel()
    {
        _titleLabel.text = LocalizationManager.Instance.GetText(_currentTitleTextKey);
    }

    private void SetTitleTextKey(string textKey)
    {
        _currentTitleTextKey = textKey;
    }
}
