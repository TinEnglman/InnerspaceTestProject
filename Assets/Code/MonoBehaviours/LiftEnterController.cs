﻿using UnityEngine;

public class LiftEnterController : MonoBehaviour
{
    [SerializeField]
    private int _sceneIndex = 0;
    [SerializeField]
    private LoadingScreenController _loadingScreenController = null;

    private void OnTriggerEnter(Collider other)
    {
        LoadingManager.Instance.StartLoading(_sceneIndex);
        _loadingScreenController.StartLoading();
    }
}
