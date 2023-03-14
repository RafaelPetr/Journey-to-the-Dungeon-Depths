using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Item/Equipment", fileName = "obj_item_equip_")]
public class Equipment : Item {

    public override void Use() {
        Debug.Log("Use Equipment");
    }
}