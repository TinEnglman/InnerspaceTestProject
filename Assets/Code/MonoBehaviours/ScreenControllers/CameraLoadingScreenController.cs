using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CameraLoadingScreenController : LoadingScreenController
{
    private const string LoadingSliderName = "SliderVR";
    private const string TitleLabelName = "TitleLabelVR";
    private const string HintLableName = "HintLabelVR";

    [SerializeField]
    private float _baseTranslationSpeed = 15f;
    [SerializeField]
    private float _baseRotationSpeed = 5f;
    [SerializeField]
    private bool _enableDmmScale = true;
    [SerializeField]
    private Vector3 _screenPosition = Vector3.zero;
    [SerializeField]
    private Vector3 _screenLookOffset = Vector3.zero;
    [SerializeField]
    private Camera _camera = null;

    private GameObject _screenPositionTracker = null;
    private Vector3 _targetPosition = Vector3.zero;
    private Quaternion _targetRotation = Quaternion.identity;

    public IScreenScaler ScreenScaler { get; set; }

    public override void Init(string initialTitleTextKey, string initialHintTextKey)
    {
        LoadingSlider = GameObject.Find(LoadingSliderName).GetComponent<Slider>();
        TitleLabel = GameObject.Find(TitleLabelName).GetComponent<TextMeshProUGUI>();
        HintLabel = GameObject.Find(HintLableName).GetComponent<TextMeshProUGUI>();

        base.Init(initialTitleTextKey, initialHintTextKey);

        _screenPositionTracker = new GameObject();
        _screenPositionTracker.transform.SetParent(_camera.transform);
        _screenPositionTracker.transform.localPosition = _screenPosition;

        RefreshLabels();
    }

    public void SetupScale()
    {
        if (_enableDmmScale)
        {
            transform.localScale = Vector3.one * ScreenScaler.GetScale(_screenPosition.magnitude);
        }
    }

    public override void Update()
    {
        base.Update();

        _targetPosition = _screenPositionTracker.transform.position;
        Vector3 lookAt = _targetPosition - _camera.transform.position + _screenLookOffset;
        _targetRotation = Quaternion.LookRotation(lookAt);

        UpdatePosition();
        UpdateRotation();
    }

    private void UpdatePosition()
    {
        Vector3 currentTranslationVelocity = (_targetPosition - transform.position) * _baseTranslationSpeed;
        transform.position += currentTranslationVelocity * Time.deltaTime;
    }

    private void UpdateRotation()
    {
        float currentRotationalStep = (_targetRotation * transform.rotation).eulerAngles.magnitude * _baseRotationSpeed * Time.deltaTime;
        transform.rotation = Quaternion.RotateTowards(transform.rotation, _targetRotation, currentRotationalStep);
    }

    ~CameraLoadingScreenController()
    {
        if (_screenPositionTracker != null && _screenPositionTracker.gameObject != null)
        { 
            Object.Destroy(_screenPositionTracker.gameObject);
        }
    }
}
