using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenScalerDmm : IScreenScaler
{
    private const float _optimalDistance = 1f;

    public float GetScale(float distanceFromCamera)
    {
        return distanceFromCamera / _optimalDistance;
    }
}
