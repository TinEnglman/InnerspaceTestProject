using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScreenController : LoadingScreenController
{
    private readonly float _optimalDistance = 1;

    [SerializeField]
    private bool _enableDmmScale = true;
    [SerializeField]
    private Vector3 _screenPosition = Vector3.zero;
    [SerializeField]
    private Camera _camera = null;

    private GameObject _screenPositionTracker = null;
    private float _distanceFromCamera = 0;

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

        transform.position = _screenPositionTracker.transform.position;
        transform.rotation = _camera.transform.rotation;
    }

    ~CameraScreenController()
    {
        if (_screenPositionTracker != null && _screenPositionTracker.gameObject != null)
        { 
            Object.Destroy(_screenPositionTracker.gameObject);
        }
    }
}
