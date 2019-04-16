using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiftExitController : MonoBehaviour
{
    [SerializeField]
    private LiftLoadingScreenController _wellcomeScreenController = null;

    private void OnTriggerExit(Collider other)
    {
        _wellcomeScreenController.Hide();
    }
}
