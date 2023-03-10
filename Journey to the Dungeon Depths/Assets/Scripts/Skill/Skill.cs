using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Skill", fileName = "obj_skill_")]
public class Skill : ScriptableObject {
    private OffensiveComponent offensiveComponent;
    private List<EffectComponent> effectComponents = new List<EffectComponent>();
}
