using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class DreamCondition : ScriptableObject
{
    public abstract bool Evaluate();
}