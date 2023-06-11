using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChangeInfoPanel : MonoBehaviour
{
    [SerializeField] GameObject _activeInfoPanel, _activeInfoPanelSpanish, _newInfoPanel, _newInfoPanelSpanish;
    bool _triggered;

    void OnTriggerEnter(Collider other)
    {
        if (_triggered)
            return;
        
        if (_activeInfoPanel != null)
            _activeInfoPanel.SetActive(false);

        if (_activeInfoPanelSpanish != null)
            _activeInfoPanelSpanish.SetActive(false);

        switch (GameManager.Instance.language)
        {
            case GameManager.Language.ENG:
                _newInfoPanel.SetActive(true);
                break;
            case GameManager.Language.SPA:
                _newInfoPanelSpanish.SetActive(true);
                break;
        }

        _triggered = true;
    }
}
