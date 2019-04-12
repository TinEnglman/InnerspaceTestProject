using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScreenController : ScreenController
{
    [SerializeField]
    private bool _enableAutoScale = true;
    [SerializeField]
    private Vector3 _screenPosition = Vector3.zero;
    [SerializeField]
    private Camera _camera = null;

    private GameObject _screenPositionTracker = null;

    public override void Init(string initialTitleTextKey, string initialHintTextKey)
    {
        base.Init(initialTitleTextKey, initialHintTextKey);
        _screenPositionTracker = new GameObject();
        _screenPositionTracker.transform.SetParent(_camera.transform);
        _screenPositionTracker.transform.localPosition = _screenPosition;
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
