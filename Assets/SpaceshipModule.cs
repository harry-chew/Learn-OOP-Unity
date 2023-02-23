using UnityEngine;

public class SpaceshipModule : MonoBehaviour
{
    public IModule moduleScriptableObject;

    public virtual string GetName()
    {
        return moduleScriptableObject.GetModuleName();
    }
}