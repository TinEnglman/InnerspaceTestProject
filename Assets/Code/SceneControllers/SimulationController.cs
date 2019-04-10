using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimulationController : MonoBehaviour
{
    [SerializeField]
    private string _textFolderName = "Texts";
    [SerializeField]
    private LiftExitController _liftController = null;
    [SerializeField]
    private WellcomeScreenController _wellcomeScreenController = null;

    void Start()
    {
        if (LocalizationManager.Instance.TextLoader == null)
        {
            LocalizationManager.Instance.TextLoader = new TextLoader();
            LocalizationManager.Instance.LoadData(_textFolderName);

            _wellcomeScreenController.RefreshLabel();
        }
    }
}
