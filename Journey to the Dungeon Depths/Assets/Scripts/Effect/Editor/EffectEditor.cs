using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class EffectEditor : Editor {
    protected void DisplayEffect(EffectCreator effect) {
        effect.SetShow(EditorGUILayout.Foldout(effect.GetShow(), effect.GetEffectType().ToString()));

        if (effect.GetShow()) {
            EditorGUILayout.BeginHorizontal();
                EditorGUILayout.LabelField("Effect Type:");
                effect.SetEffectType((EffectType)EditorGUILayout.EnumPopup(effect.GetEffectType()));
            EditorGUILayout.EndHorizontal();

            DisplayType(effect);

            if (effect.GetEffectType() != EffectType.Damage) {
                GUILayout.Label("");

                EditorGUILayout.BeginHorizontal();
                    EditorGUILayout.LabelField("Permanent:");
                    effect.SetIsPermanent(EditorGUILayout.Toggle(effect.GetIsPermanent()));
                EditorGUILayout.EndHorizontal();

                if (!effect.GetIsPermanent()) {
                    EditorGUILayout.BeginHorizontal();
                        EditorGUILayout.LabelField("Duration:");
                        effect.SetDuration(EditorGUILayout.IntField(effect.GetDuration()));
                    EditorGUILayout.EndHorizontal();
                }
            }

            GUILayout.Label("");
            
            DisplayTarget(effect);

            GUILayout.Label("");
        }
    }

    protected void DisplayType(EffectCreator effect) {
        switch (effect.GetEffectType()) {
            case EffectType.Attribute:
                AttributeModifier modifier = effect.GetAttributeModifier();

                EditorGUILayout.BeginHorizontal();
                    EditorGUILayout.LabelField("Attribute Type:");
                    modifier.SetAttributeType((AttributeType)EditorGUILayout.EnumPopup(modifier.GetAttributeType()));
                EditorGUILayout.EndHorizontal();

                EditorGUILayout.BeginHorizontal();
                    modifier.SetValue(EditorGUILayout.IntField("Modifier:",modifier.GetValue()));
                    modifier.SetModifierType((AttributeModifierType)EditorGUILayout.EnumPopup(modifier.GetModifierType()));
                EditorGUILayout.EndHorizontal();
                break;

            case EffectType.Damage:
                EditorGUILayout.BeginHorizontal();
                    EditorGUILayout.LabelField("Damage Type:");
                    effect.SetDamageType((DamageType)EditorGUILayout.EnumPopup(effect.GetDamageType()));
                EditorGUILayout.EndHorizontal();

                EditorGUILayout.BeginHorizontal();
                    EditorGUILayout.LabelField("Damage Modifier:");
                    effect.SetDamageModifier(EditorGUILayout.IntField(effect.GetDamageModifier()));
                EditorGUILayout.EndHorizontal();
                break;
                
            case EffectType.Immunity: 
            case EffectType.Condition:
                EditorGUILayout.BeginHorizontal();
                    EditorGUILayout.LabelField("Condition Type:");
                    effect.SetConditionType((ConditionType)EditorGUILayout.EnumPopup(effect.GetConditionType()));
                EditorGUILayout.EndHorizontal();
                break;
        }
    }

    protected void DisplayTarget(EffectCreator effect) {
        EditorGUILayout.BeginHorizontal();
            EditorGUILayout.LabelField("Target Type:");
            effect.SetTargetType((TargetType)EditorGUILayout.EnumPopup(effect.GetTargetType()));
        EditorGUILayout.EndHorizontal();

        switch (effect.GetTargetType()) {
            case TargetType.Single:
                if (effect.GetIsRandom()) {
                    effect.SetTargetSelf(false);

                    EditorGUILayout.BeginHorizontal();
                        EditorGUILayout.LabelField("Random:");
                        effect.SetIsRandom(EditorGUILayout.Toggle(effect.GetIsRandom()));
                    EditorGUILayout.EndHorizontal();
                }
                else if (effect.GetTargetSelf()) {
                    effect.SetIsRandom(false);

                    EditorGUILayout.BeginHorizontal();
                        EditorGUILayout.LabelField("Self:");
                        effect.SetTargetSelf(EditorGUILayout.Toggle(effect.GetTargetSelf()));
                    EditorGUILayout.EndHorizontal();
                }
                else {
                    EditorGUILayout.BeginHorizontal();
                        EditorGUILayout.LabelField("Random:");
                        effect.SetIsRandom(EditorGUILayout.Toggle(effect.GetIsRandom()));
                    EditorGUILayout.EndHorizontal();

                    EditorGUILayout.BeginHorizontal();
                        EditorGUILayout.LabelField("Self:");
                        effect.SetTargetSelf(EditorGUILayout.Toggle(effect.GetTargetSelf()));
                    EditorGUILayout.EndHorizontal();
                }
                break;

            case TargetType.Multiple:
                EditorGUILayout.BeginHorizontal();
                    EditorGUILayout.LabelField("Number of Targets:");
                    effect.SetNumberTargets(EditorGUILayout.IntField(effect.GetNumberTargets()));
                EditorGUILayout.EndHorizontal();

                EditorGUILayout.BeginHorizontal();
                    EditorGUILayout.LabelField("Random:");
                    effect.SetIsRandom(EditorGUILayout.Toggle(effect.GetIsRandom()));
                EditorGUILayout.EndHorizontal();

                EditorGUILayout.BeginHorizontal();
                    EditorGUILayout.LabelField("Self:");
                    effect.SetTargetSelf(EditorGUILayout.Toggle(effect.GetTargetSelf()));
                EditorGUILayout.EndHorizontal();
                break;

            case TargetType.All:
                EditorGUILayout.BeginHorizontal();
                    EditorGUILayout.LabelField("Self:");
                    effect.SetTargetSelf(EditorGUILayout.Toggle(effect.GetTargetSelf()));
                EditorGUILayout.EndHorizontal();
                break;
        }
    }
}
