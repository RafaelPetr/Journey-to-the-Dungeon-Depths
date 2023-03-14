using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class ItemEditor : EffectEditor {
    private int tabIndex;

    public override void OnInspectorGUI() {
        Item item = (Item)target;

        tabIndex = GUILayout.Toolbar(tabIndex, new string[]{"Details","Effects"});

        GUILayout.Label("", GUI.skin.horizontalSlider);
        GUILayout.Label("");

        switch(tabIndex) {
            case 0:
                DetailsTab(item);
                break;
            case 1:
                EffectsTab(item);
                break;
        }

        EditorUtility.SetDirty(item);
    }

    private void DetailsTab(Item item) {
        item.SetName(EditorGUILayout.TextField("Name:",item.GetName()));

        EditorGUILayout.BeginHorizontal();
            EditorGUILayout.LabelField("Sprite:");
            item.SetSprite((Sprite)EditorGUILayout.ObjectField(item.GetSprite(),typeof(Sprite),false));
        EditorGUILayout.EndHorizontal();

        GUILayout.Label("");

        EditorGUILayout.LabelField("Description:");
        item.SetDescription(GUILayout.TextArea(item.GetDescription()));
    }

    private void EffectsTab(Item item) {
        for (int i = 0; i < item.GetEffects().Count; i++) {
            DisplayEffect(item.GetEffects(i));

            if (GUILayout.Button("Remove")) {
                item.RemoveEffect(i);
            }

            EditorGUILayout.LabelField("", GUI.skin.horizontalSlider);
        }

        if (GUILayout.Button("Add")) {
            item.AddEffect(new EffectCreator());
        }
    }
}
