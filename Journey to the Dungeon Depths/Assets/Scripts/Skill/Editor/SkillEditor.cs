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

        DisplayComponent(offComponent);

        EditorGUILayout.BeginHorizontal();
            EditorGUILayout.LabelField("Damage Percent:");
            offComponent.SetDamagePercent(EditorGUILayout.IntField(offComponent.GetDamagePercent()));
        EditorGUILayout.EndHorizontal();

        EditorGUILayout.BeginHorizontal();
            EditorGUILayout.LabelField("Damage Type:");
            offComponent.SetDamageType((DamageType)EditorGUILayout.EnumPopup(offComponent.GetDamageType()));
        EditorGUILayout.EndHorizontal();
    }

    private void EffectsTab(Skill skill) {

    }

    private void DisplayComponent(SkillComponent component) {
        EditorGUILayout.BeginHorizontal();
            EditorGUILayout.LabelField("Target Type:");
            component.SetTargetType((TargetType)EditorGUILayout.EnumPopup(component.GetTargetType()));
        EditorGUILayout.EndHorizontal();

        if (component.GetTargetType() == TargetType.Multiple || component.GetTargetType() == TargetType.MultipleOther) {
            component.SetNumberTargets(EditorGUILayout.IntField("Number of Targets",component.GetNumberTargets()));
        }

        if (component.GetTargetType() != TargetType.Self) {
            EditorGUILayout.BeginHorizontal();
                EditorGUILayout.LabelField("Random:");
                component.SetIsRandom(EditorGUILayout.Toggle(component.GetIsRandom()));
            EditorGUILayout.EndHorizontal();
        }
    }
}
