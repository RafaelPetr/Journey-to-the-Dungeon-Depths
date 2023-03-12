using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Item))]
public class ItemEditor : Editor {
    public override void OnInspectorGUI() {
        Item item = (Item)target;

        EditorGUILayout.BeginHorizontal();
            EditorGUILayout.LabelField("Name:");
            item.SetName(EditorGUILayout.TextField(item.GetName()));
        EditorGUILayout.EndHorizontal();

        EditorGUILayout.BeginHorizontal();
            EditorGUILayout.LabelField("Description:");
            item.SetDescription(GUILayout.TextArea(item.GetDescription()));
        EditorGUILayout.EndHorizontal();

        EditorGUILayout.BeginHorizontal();
            EditorGUILayout.LabelField("Sprite:");
            item.SetSprite((Sprite)EditorGUILayout.ObjectField(item.GetSprite(),typeof(Sprite),false));
        EditorGUILayout.EndHorizontal();

        GUILayout.Label("", GUI.skin.horizontalSlider);
        GUILayout.Label("");
        GUILayout.Label("Effects:");
        GUILayout.Label("");
        DisplayEffectsList(item);

        EditorUtility.SetDirty(item);
    }

    private void DisplayEffectsList(Item item) {
        for (int i = 0; i < item.GetEffComponents().Count; i++) {
            EditorGUILayout.LabelField("Effect " + i);

            EffectComponent effComponent = item.GetEffComponents(i);

            EditorGUILayout.BeginHorizontal();
                EditorGUILayout.LabelField("Permanent:");
                effComponent.SetIsPermanent(EditorGUILayout.Toggle(effComponent.GetIsPermanent()));
            EditorGUILayout.EndHorizontal();

            if (!effComponent.GetIsPermanent()) {
                EditorGUILayout.BeginHorizontal();
                    EditorGUILayout.LabelField("Duration:");
                    effComponent.SetDuration(EditorGUILayout.IntField(effComponent.GetDuration()));
                EditorGUILayout.EndHorizontal();
            }

            GUILayout.Label("");

            EditorGUILayout.BeginHorizontal();
                EditorGUILayout.LabelField("Effect Type:");
                effComponent.SetEffectType((EffectType)EditorGUILayout.EnumPopup(effComponent.GetEffectType()));
            EditorGUILayout.EndHorizontal();
            
            DisplayEffect(effComponent);

            GUILayout.Label("");

            DisplayComponent(effComponent);

            if (GUILayout.Button("Remove")) {
                item.RemoveEffComponent(i);
            }

            EditorGUILayout.LabelField("", GUI.skin.horizontalSlider);
        }

        if (GUILayout.Button("Add")) {
            item.AddEffComponent(new EffectComponent());
        }
    }

    private void DisplayComponent(SkillComponent component) {
        EditorGUILayout.BeginHorizontal();
            EditorGUILayout.LabelField("Target Type:");
            component.SetTargetType((TargetType)EditorGUILayout.EnumPopup(component.GetTargetType()));
        EditorGUILayout.EndHorizontal();

        if (component.GetTargetType() == TargetType.Single) {
            if (component.GetIsRandom()) {
                component.SetTargetSelf(false);

                EditorGUILayout.BeginHorizontal();
                    EditorGUILayout.LabelField("Random:");
                    component.SetIsRandom(EditorGUILayout.Toggle(component.GetIsRandom()));
                EditorGUILayout.EndHorizontal();
            }
            else if (component.GetTargetSelf()) {
                component.SetIsRandom(false);

                EditorGUILayout.BeginHorizontal();
                    EditorGUILayout.LabelField("Self:");
                    component.SetTargetSelf(EditorGUILayout.Toggle(component.GetTargetSelf()));
                EditorGUILayout.EndHorizontal();
            }
            else {
                EditorGUILayout.BeginHorizontal();
                    EditorGUILayout.LabelField("Random:");
                    component.SetIsRandom(EditorGUILayout.Toggle(component.GetIsRandom()));
                EditorGUILayout.EndHorizontal();

                EditorGUILayout.BeginHorizontal();
                    EditorGUILayout.LabelField("Self:");
                    component.SetTargetSelf(EditorGUILayout.Toggle(component.GetTargetSelf()));
                EditorGUILayout.EndHorizontal();
            }
        }

        if (component.GetTargetType() == TargetType.Multiple) {
            EditorGUILayout.BeginHorizontal();
                EditorGUILayout.LabelField("Number of Targets:");
                component.SetNumberTargets(EditorGUILayout.IntField(component.GetNumberTargets()));
            EditorGUILayout.EndHorizontal();

            EditorGUILayout.BeginHorizontal();
                EditorGUILayout.LabelField("Random:");
                component.SetIsRandom(EditorGUILayout.Toggle(component.GetIsRandom()));
            EditorGUILayout.EndHorizontal();

            EditorGUILayout.BeginHorizontal();
                EditorGUILayout.LabelField("Self:");
                component.SetTargetSelf(EditorGUILayout.Toggle(component.GetTargetSelf()));
            EditorGUILayout.EndHorizontal();
        }
    }

    private void DisplayEffect(EffectComponent effComponent) {
        switch (effComponent.GetEffectType()) {
            case EffectType.Attribute:
                AttributeModifier modifier = effComponent.GetAttributeModifier();

                EditorGUILayout.BeginHorizontal();
                    EditorGUILayout.LabelField("Modifier:");
                    modifier.SetValue(EditorGUILayout.IntField(modifier.GetValue()));
                EditorGUILayout.EndHorizontal();

                EditorGUILayout.BeginHorizontal();
                    EditorGUILayout.LabelField("Attribute Type:");
                    modifier.SetAttributeType((AttributeType)EditorGUILayout.EnumPopup(modifier.GetAttributeType()));
                EditorGUILayout.EndHorizontal();

                EditorGUILayout.BeginHorizontal();
                    EditorGUILayout.LabelField("Modifier Type:");
                    modifier.SetModifierType((AttributeModifierType)EditorGUILayout.EnumPopup(modifier.GetModifierType()));
                EditorGUILayout.EndHorizontal();
                break;
            case EffectType.Immunity: 
            case EffectType.Condition:
                EditorGUILayout.BeginHorizontal();
                    EditorGUILayout.LabelField("Condition Type:");
                    effComponent.SetConditionType((ConditionType)EditorGUILayout.EnumPopup(effComponent.GetConditionType()));
                EditorGUILayout.EndHorizontal();
                break;
        }
    }
}
