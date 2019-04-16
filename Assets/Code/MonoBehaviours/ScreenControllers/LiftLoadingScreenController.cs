using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LiftLoadingScreenController : LoadingScreenController
{
    private const string LoadingSliderName = "Slider";
    private const string TitleLabelName = "TitleLabel";
    private const string HintLableName = "HintLabel";

    public override void Init(string initialTitleTextKey, string initialHintTextKey)
    {
        LoadingSlider = GameObject.Find(LoadingSliderName).GetComponent<Slider>();
        TitleLabel = GameObject.Find(TitleLabelName).GetComponent<TextMeshProUGUI>();
        HintLabel = GameObject.Find(HintLableName).GetComponent<TextMeshProUGUI>();

        base.Init(initialTitleTextKey, initialHintTextKey);

        RefreshLabels();
    }
}
