using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvailableModules : MonoBehaviour
{
    public List<ModuleScriptableObject> availableModules = new List<ModuleScriptableObject>();
    
    public static AvailableModules Instance;
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void Start()
    {
        
    }
    public void AddModule(ModuleScriptableObject module)
    {
        availableModules.Add(module);
    }

    public void RemoveModule(ModuleScriptableObject module)
    {
        availableModules.Remove(module);
    }

    public List<ModuleScriptableObject> GetAvailableModules()
    {
        return availableModules;
    }
}
