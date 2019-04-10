using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiftExitController : MonoBehaviour
{
    [SerializeField]
    private DoorController _doorController = null;
    [SerializeField]
    private WellcomeScreenController _wellcomeScreenController = null;

    private void OnTriggerExit(Collider other)
    {
        //_wellcomeScreenController.
    }
}
