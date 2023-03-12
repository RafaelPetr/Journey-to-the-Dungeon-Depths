using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Stats))]
public class statsEditor : Editor {
    public override void OnInspectorGUI() {
        Stats stats = (Stats)target;

        GUILayout.BeginHorizontal();
            GUILayout.Label("HP:");
            stats.SetHp(EditorGUILayout.IntField(stats.GetHp().GetValue()));
        GUILayout.EndHorizontal();

        GUILayout.BeginHorizontal();
            GUILayout.Label("SP:");
            stats.SetSp(EditorGUILayout.IntField(stats.GetSp().GetValue()));
        GUILayout.EndHorizontal();

        GUILayout.BeginHorizontal();
            GUILayout.Label("ATK:");
            stats.SetAtk(EditorGUILayout.IntField(stats.GetAtk().GetValue()));
        GUILayout.EndHorizontal();

        GUILayout.BeginHorizontal();
            GUILayout.Label("MAG:");
            stats.SetMag(EditorGUILayout.IntField(stats.GetMag().GetValue()));
        GUILayout.EndHorizontal();

        GUILayout.BeginHorizontal();
            GUILayout.Label("AGI:");
            stats.SetAgi(EditorGUILayout.IntField(stats.GetAgi().GetValue()));
        GUILayout.EndHorizontal();

        GUILayout.BeginHorizontal();
            GUILayout.Label("LUK:");
            stats.SetLuk(EditorGUILayout.IntField(stats.GetLuk().GetValue()));
        GUILayout.EndHorizontal();

        EditorGUILayout.LabelField("",GUI.skin.horizontalSlider);

        GUILayout.BeginHorizontal();

            GUILayout.BeginVertical();
                GUILayout.Label("Physical:");
                stats.SetPhysRes(EditorGUILayout.IntField(stats.GetPhysicalRes().GetValue()));
            GUILayout.EndVertical();

            GUILayout.BeginVertical();
                GUILayout.Label("Fire:");
                stats.SetFireRes(EditorGUILayout.IntField(stats.GetFireRes().GetValue()));
            GUILayout.EndVertical();

            GUILayout.BeginVertical();
                GUILayout.Label("Lightning:");
                stats.SetLightningRes(EditorGUILayout.IntField(stats.GetLightningRes().GetValue()));
            GUILayout.EndVertical();

            GUILayout.BeginVertical();
                GUILayout.Label("Water:");
                stats.SetWaterRes(EditorGUILayout.IntField(stats.GetWaterRes().GetValue()));
            GUILayout.EndVertical();
       
        GUILayout.EndHorizontal();

        EditorGUILayout.LabelField("",GUI.skin.horizontalSlider);

        GUILayout.BeginHorizontal();
            GUILayout.Label("Damage Type:");
            stats.SetDamageType((DamageType)EditorGUILayout.EnumPopup(stats.GetDamageType()));
        GUILayout.EndHorizontal();
        
        EditorUtility.SetDirty(stats);
    } 
}
