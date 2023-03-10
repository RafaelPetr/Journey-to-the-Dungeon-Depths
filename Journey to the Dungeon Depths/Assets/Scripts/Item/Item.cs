using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Item : ScriptableObject {
    private string itemName;
    private string description;

    private Sprite sprite;

    public abstract void Use();
}
