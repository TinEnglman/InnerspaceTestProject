using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    [SerializeField]
    private LiftController _liftController;

    void Start()
    {
        _liftController.SceneLoader = new SceneLoader();
    }
}
