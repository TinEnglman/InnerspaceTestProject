using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimulationController : MonoBehaviour
{
    [SerializeField]
    private string _textFolderName = "Texts";
    [SerializeField]
    private WellcomeScreenController _wellcomeScreenController;

    void Start()
    {
        if (LocalizationManager.Instance.TextLoader == null)
        {
            LocalizationManager.Instance.TextLoader = new TextLoader();
            LocalizationManager.Instance.LoadData(_textFolderName);
        }

        _wellcomeScreenController.Init();
    }
}
