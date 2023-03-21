using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Stats))]
public class StatsEditor : Editor {
    private int statsPoints, growthPoints;

    public override void OnInspectorGUI() {
        Stats stats = (Stats)target;

        if (!stats.GetHasDifficulty()) {
            GUILayout.Label("Creature Difficulty:");
            stats.SetDifficulty((Difficulty)EditorGUILayout.EnumPopup(stats.GetDifficulty()));

            if (GUILayout.Button("Create")) {
                statsPoints = 70 * ((int)stats.GetDifficulty() + 1)/2;

                stats.SetHasDifficulty(true);

                stats.SetHp(statsPoints/7);
                stats.SetSp(statsPoints/7);
                stats.SetAtk(statsPoints/7);
                stats.SetMag(statsPoints/7);
                stats.SetDef(statsPoints/7);
                stats.SetMagDef(statsPoints/7);
                stats.SetAgi(statsPoints/7);
            }
        }
        else {
            GUILayout.BeginHorizontal();
            GUILayout.Label("Attribute Points: " + statsPoints);
            GUILayout.Label("Growth Points: " + growthPoints);
            GUILayout.EndHorizontal();
            
            statsPoints = 70 * ((int)stats.GetDifficulty() + 1)/2;
            growthPoints = 7;

            EditorGUILayout.LabelField("",GUI.skin.horizontalSlider);

            GUILayout.BeginHorizontal();
                GUILayout.Label("HP:");
                stats.SetHp(EditorGUILayout.IntField(stats.GetHp().GetValue()));
                stats.SetHp((AttributeGrowthType)EditorGUILayout.EnumPopup(stats.GetHp().GetLevelType()));

                statsPoints -= stats.GetHp().GetValue();
                growthPoints -= (int)stats.GetHp().GetLevelType();
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal();
                GUILayout.Label("SP:");
                stats.SetSp(EditorGUILayout.IntField(stats.GetSp().GetValue()));
                stats.SetSp((AttributeGrowthType)EditorGUILayout.EnumPopup(stats.GetSp().GetLevelType()));

                statsPoints -= stats.GetSp().GetValue();
                growthPoints -= (int)stats.GetSp().GetLevelType();
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal();
                GUILayout.Label("ATK:");
                stats.SetAtk(EditorGUILayout.IntField(stats.GetAtk().GetValue()));
                stats.SetAtk((AttributeGrowthType)EditorGUILayout.EnumPopup(stats.GetAtk().GetLevelType()));

                statsPoints -= stats.GetAtk().GetValue();
                growthPoints -= (int)stats.GetAtk().GetLevelType();
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal();
                GUILayout.Label("MAG:");
                stats.SetMag(EditorGUILayout.IntField(stats.GetMag().GetValue()));
                stats.SetMag((AttributeGrowthType)EditorGUILayout.EnumPopup(stats.GetMag().GetLevelType()));

                statsPoints -= stats.GetMag().GetValue();
                growthPoints -= (int)stats.GetMag().GetLevelType();
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal();
                GUILayout.Label("DEF:");
                stats.SetDef(EditorGUILayout.IntField(stats.GetDef().GetValue()));
                stats.SetDef((AttributeGrowthType)EditorGUILayout.EnumPopup(stats.GetDef().GetLevelType()));

                statsPoints -= stats.GetDef().GetValue();
                growthPoints -= (int)stats.GetDef().GetLevelType();
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal();
                GUILayout.Label("MAG.DEF:");
                stats.SetMagDef(EditorGUILayout.IntField(stats.GetMagDef().GetValue()));
                stats.SetMagDef((AttributeGrowthType)EditorGUILayout.EnumPopup(stats.GetMagDef().GetLevelType()));

                statsPoints -= stats.GetMagDef().GetValue();
                growthPoints -= (int)stats.GetMagDef().GetLevelType();
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal();
                GUILayout.Label("AGI:");
                stats.SetAgi(EditorGUILayout.IntField(stats.GetAgi().GetValue()));
                stats.SetAgi((AttributeGrowthType)EditorGUILayout.EnumPopup(stats.GetAgi().GetLevelType()));

                statsPoints -= stats.GetAgi().GetValue();
                growthPoints -= (int)stats.GetAgi().GetLevelType();
            GUILayout.EndHorizontal();

            EditorGUILayout.LabelField("",GUI.skin.horizontalSlider);

            GUILayout.BeginHorizontal();

                GUILayout.BeginVertical();
                    GUILayout.Label("Fire:");
                    stats.SetFireRes(EditorGUILayout.IntField(stats.GetFireRes().GetValue()));
                GUILayout.EndVertical();

                GUILayout.BeginVertical();
                    GUILayout.Label("Lightning:");
                    stats.SetLightningRes(EditorGUILayout.IntField(stats.GetLightningRes().GetValue()));
                GUILayout.EndVertical();

                GUILayout.BeginVertical();
                    GUILayout.Label("Ice:");
                    stats.SetIceRes(EditorGUILayout.IntField(stats.GetIceRes().GetValue()));
                GUILayout.EndVertical();
        
            GUILayout.EndHorizontal();

            EditorGUILayout.LabelField("",GUI.skin.horizontalSlider);

            GUILayout.BeginHorizontal();
                GUILayout.Label("Damage Type:");
                stats.SetDamageType((DamageType)EditorGUILayout.EnumPopup(stats.GetDamageType()));
            GUILayout.EndHorizontal();
        }
        
        EditorUtility.SetDirty(stats);
    } 
}
