using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerController : MonoBehaviour
{
    public bool IsTriggered { get; set; }

    private void OnTriggerEnter(Collider other)
    {
        IsTriggered = true;
    }

    private void OnTriggerExit(Collider other)
    {
        IsTriggered = false;
    }
}
