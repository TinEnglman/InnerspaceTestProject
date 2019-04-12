using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScreenController : ScreenController
{
    [SerializeField]
    private bool _enableAutoScale = true;
    [SerializeField]
    private Vector3 _screenPosition;
    [SerializeField]
    private Camera _camera;

    public override void Update()
    {
        base.Update();
        transform.position = _screenPosition + _camera.transform.position;
        transform.rotation = _camera.transform.rotation;
    }
}
