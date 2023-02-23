using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ButtonTemplateBuilder : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;

    public void SetName(string name)
    {
        text.text = name;
    }
}
