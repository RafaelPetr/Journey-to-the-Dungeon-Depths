using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImmunityEffect : Effect {
    private ConditionType conditionType;
    
    public override void Execute() {
        Debug.Log("Execute Immunity Effect");
    }
}