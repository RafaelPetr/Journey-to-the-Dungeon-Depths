using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Skill))]
public class SkillEditor : EffectEditor {
    private int tabIndex;

    public override void OnInspectorGUI() {
        Skill skill = (Skill)target;

        tabIndex = GUILayout.Toolbar(tabIndex, new string[]{"Details","Effects"});

        GUILayout.Label("", GUI.skin.horizontalSlider);
        GUILayout.Label("");

        switch(tabIndex) {
            case 0:
                DetailsTab(skill);
                break;
            case 1:
                EffectsTab(skill);
                break;
        }

        EditorUtility.SetDirty(skill);
    }

    private void DetailsTab(Skill skill) {
        skill.SetName(EditorGUILayout.TextField("Name: ", skill.GetName()));

        EditorGUILayout.BeginHorizontal();
            EditorGUILayout.LabelField("Sprite:");
            skill.SetSprite((Sprite)EditorGUILayout.ObjectField(skill.GetSprite(),typeof(Sprite),false));
        EditorGUILayout.EndHorizontal();

        GUILayout.Label("");

        GUILayout.Label("Description:");
        skill.SetDescription(GUILayout.TextArea(skill.GetDescription()));
    }

    private void EffectsTab(Skill skill) {
        for (int i = 0; i < skill.GetEffects().Count; i++) {
            DisplayEffect(skill.GetEffects(i));

            if (GUILayout.Button("Remove")) {
                skill.RemoveEffect(i);
            }

            EditorGUILayout.LabelField("", GUI.skin.horizontalSlider);
        }

        if (GUILayout.Button("Add")) {
            skill.AddEffect(new EffectCreator());
        }
    }
}
