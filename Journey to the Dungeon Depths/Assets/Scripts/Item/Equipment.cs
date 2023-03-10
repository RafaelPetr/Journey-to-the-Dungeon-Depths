using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Item/Equipment", fileName = "obj_item_equip_")]
public class Equipment : Item {
    private List<EffectComponent> effectComponents = new List<EffectComponent>();

    public override void Use() {
        Debug.Log("Use Equipment");
    }
}