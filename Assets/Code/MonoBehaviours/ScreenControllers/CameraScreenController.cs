using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScreenController : LoadingScreenController
{
    private readonly float _optimalDistance = 1;
    private readonly float _baseTranslationSpeed = 15f;
    private readonly float _baseRotationSpeed = 5;

    [SerializeField]
    private bool _enableDmmScale = true;
    [SerializeField]
    private Vector3 _screenPosition = Vector3.zero;
    [SerializeField]
    private Camera _camera = null;

    private GameObject _screenPositionTracker = null;
    private float _distanceFromCamera = 0;

    private Vector3 _targetPosition = Vector3.zero;
    private Quaternion _targetRotation = Quaternion.identity;

    public override void Init(string initialTitleTextKey, string initialHintTextKey)
    {
        base.Init(initialTitleTextKey, initialHintTextKey);

        _screenPositionTracker = new GameObject();
        _screenPositionTracker.transform.SetParent(_camera.transform);
        _screenPositionTracker.transform.localPosition = _screenPosition;

        if (_enableDmmScale)
        { 
            _distanceFromCamera = _screenPosition.magnitude;
            float scale = _screenPosition.magnitude / _optimalDistance;
            transform.localScale = Vector3.one * scale;
        }
    }

    public override void Update()
    {
        base.Update();

        _targetPosition = _screenPositionTracker.transform.position;
        _targetRotation = _camera.transform.rotation;

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

    ~CameraScreenController()
    {
        if (_screenPositionTracker != null && _screenPositionTracker.gameObject != null)
        { 
            Object.Destroy(_screenPositionTracker.gameObject);
        }
    }
}
