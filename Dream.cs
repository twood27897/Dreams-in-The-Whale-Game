using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Dream", menuName = "DreamsScriptableObjects/Dream", order = 1)]
public class Dream : ScriptableObject
{
    [SerializeField] public string sceneName;
    [SerializeField] public List<DreamCondition> conditions;

}
