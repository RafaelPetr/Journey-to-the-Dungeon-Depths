using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(CharacterAttributes))]
public class AttributesEditor : Editor {
    public override void OnInspectorGUI() {
        CharacterAttributes attributes = (CharacterAttributes)target;

        GUILayout.BeginHorizontal();
            GUILayout.Label("HP:");
            attributes.SetHp(EditorGUILayout.IntField(attributes.GetHp().GetValue()));
        GUILayout.EndHorizontal();

        GUILayout.BeginHorizontal();
            GUILayout.Label("SP:");
            attributes.SetSp(EditorGUILayout.IntField(attributes.GetSp().GetValue()));
        GUILayout.EndHorizontal();

        GUILayout.BeginHorizontal();
            GUILayout.Label("ATK:");
            attributes.SetAtk(EditorGUILayout.IntField(attributes.GetAtk().GetValue()));
        GUILayout.EndHorizontal();

        GUILayout.BeginHorizontal();
            GUILayout.Label("MAG:");
            attributes.SetMag(EditorGUILayout.IntField(attributes.GetMag().GetValue()));
        GUILayout.EndHorizontal();

        GUILayout.BeginHorizontal();
            GUILayout.Label("AGI:");
            attributes.SetAgi(EditorGUILayout.IntField(attributes.GetAgi().GetValue()));
        GUILayout.EndHorizontal();

        GUILayout.BeginHorizontal();
            GUILayout.Label("LUK:");
            attributes.SetLuk(EditorGUILayout.IntField(attributes.GetLuk().GetValue()));
        GUILayout.EndHorizontal();

        EditorGUILayout.LabelField("",GUI.skin.horizontalSlider);
        GUILayout.Label("Resistences:");

        GUILayout.BeginHorizontal();

            GUILayout.BeginVertical();
                GUILayout.Label("Physical:");
                attributes.SetPhysRes(EditorGUILayout.IntField(attributes.GetPhysRes().GetValue()));
            GUILayout.EndVertical();

            GUILayout.BeginVertical();
                GUILayout.Label("Fire:");
                attributes.SetFireRes(EditorGUILayout.IntField(attributes.GetFireRes().GetValue()));
            GUILayout.EndVertical();

            GUILayout.BeginVertical();
                GUILayout.Label("Lightning:");
                attributes.SetLightningRes(EditorGUILayout.IntField(attributes.GetLightningRes().GetValue()));
            GUILayout.EndVertical();

            GUILayout.BeginVertical();
                GUILayout.Label("Water:");
                attributes.SetWaterRes(EditorGUILayout.IntField(attributes.GetWaterRes().GetValue()));
            GUILayout.EndVertical();
       
        GUILayout.EndHorizontal();

        EditorGUILayout.LabelField("",GUI.skin.horizontalSlider);

        GUILayout.BeginHorizontal();
            GUILayout.Label("Damage Type:");
            attributes.SetDamageType((DamageType)EditorGUILayout.EnumPopup(attributes.GetDamageType()));
        GUILayout.EndHorizontal();
        
        EditorUtility.SetDirty(attributes);
    } 
}
