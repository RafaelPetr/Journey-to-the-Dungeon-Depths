using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Equipment))]
public class EquipmentEditor : ItemEditor {
    public override void OnInspectorGUI() {
        base.OnInspectorGUI();
    }
}
