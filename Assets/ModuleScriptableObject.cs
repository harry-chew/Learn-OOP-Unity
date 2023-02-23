using UnityEngine;

[CreateAssetMenu(fileName = "Module", menuName = "SpaceShip/ModuleScriptableObject", order = 1)]
public class ModuleScriptableObject : ScriptableObject, IModule
{
    public int moduleId;
    public string moduleName;
    public int moduleCost;
    public ModuleType moduleType;

    public int GetModuleId()
    {
        return moduleId;
    }

    public string GetModuleName()
    {
        return moduleName;
    }

    public void SetModuleId(int moduleId)
    {
        this.moduleId = moduleId;
    }

    public void SetModuleName(string moduleName)
    {
        this.moduleName = moduleName;
    }
}