using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Consumable : Item {
    private int quantity;

    public override void Use() {
        Debug.Log("Use Consumable");
    }
}
