using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Skill))]
public class SkillEditor : Editor {
    private int tabIndex;

    public override void OnInspectorGUI() {
        Skill skill = (Skill)target;

        tabIndex = GUILayout.Toolbar(tabIndex, new string[]{"Details","Offensive","Effects"});

        GUILayout.Label("", GUI.skin.horizontalSlider);
        GUILayout.Label("");

        switch(tabIndex) {
            case 0:
                DetailsTab(skill);
                break;
            case 1:
                OffensiveTab(skill);
                break;
            case 2:
                EffectsTab(skill);
                break;
        }

        EditorUtility.SetDirty(skill);
    }

    private void DetailsTab(Skill skill) {
        skill.SetName(EditorGUILayout.TextField("Skill Name: ", skill.GetName()));

        GUILayout.Label("");

        EditorGUILayout.BeginHorizontal();
            GUILayout.Label("Description:");
            skill.SetDescription(GUILayout.TextArea(skill.GetDescription()));
        EditorGUILayout.EndHorizontal();
    }

    private void OffensiveTab(Skill skill) {
        OffensiveComponent offComponent = skill.GetOffComponent();

        if (offComponent == null) {
            if (GUILayout.Button("Add")) {
                skill.SetOffComponent(new OffensiveComponent());
            }
        }
        else {
            EditorGUILayout.BeginHorizontal();
                EditorGUILayout.LabelField("Damage Type:");
                offComponent.SetDamageType((DamageType)EditorGUILayout.EnumPopup(offComponent.GetDamageType()));
            EditorGUILayout.EndHorizontal();

            EditorGUILayout.BeginHorizontal();
                EditorGUILayout.LabelField("Damage Percent:");
                offComponent.SetDamagePercent(EditorGUILayout.IntField(offComponent.GetDamagePercent()));
            EditorGUILayout.EndHorizontal();

            EditorGUILayout.LabelField("");

            DisplayComponent(offComponent);

            GUILayout.Label("", GUI.skin.horizontalSlider);
            GUILayout.Label("");

            if (GUILayout.Button("Remove")) {
                skill.SetOffComponent(null);
            }
        }
    }

    private void EffectsTab(Skill skill) {
        for (int i = 0; i < skill.GetEffComponents().Count; i++) {
            EditorGUILayout.LabelField("Effect " + i);

            EffectComponent effComponent = skill.GetEffComponents(i);

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
                skill.RemoveEffComponent(i);
            }

            EditorGUILayout.LabelField("", GUI.skin.horizontalSlider);
        }

        if (GUILayout.Button("Add")) {
            skill.AddEffComponent(new EffectComponent());
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
