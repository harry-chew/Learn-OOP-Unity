using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ModuleBar : MonoBehaviour
{
    public GameObject moduleButtonTemplate;

    void Start() 
    {   
        BuildModuleBarButtons();
    }

    void BuildModuleBarButtons()
    {
        if (!moduleButtonTemplate) return;
        if(moduleButtonTemplate.GetComponent<ButtonTemplateBuilder>() == null) return;
        
        var availableModules = AvailableModules.Instance.GetAvailableModules();
        foreach (ModuleScriptableObject module in availableModules)
        {
            GameObject moduleButton = Instantiate(moduleButtonTemplate, transform);
            moduleButton.name = module.moduleName;
            moduleButton.transform.GetComponent<ButtonTemplateBuilder>().SetName(module.moduleName);
        }

        moduleButtonTemplate.SetActive(false);
        //very slight optimisation
        this.enabled = false;
    }
}
