using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Consumable))]
public class ConsumableEditor : ItemEditor {
    public override void OnInspectorGUI() {
        base.OnInspectorGUI();
    }
}
