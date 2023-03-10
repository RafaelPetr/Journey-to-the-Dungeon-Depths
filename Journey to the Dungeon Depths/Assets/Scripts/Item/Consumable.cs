using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Item/Consumable", fileName = "obj_item_consum_")]
public class Consumable : Item {
    public override void Use() {
        Debug.Log("Use Consumable");
    }
}
