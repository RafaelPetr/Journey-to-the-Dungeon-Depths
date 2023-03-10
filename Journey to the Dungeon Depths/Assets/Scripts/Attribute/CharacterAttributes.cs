using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Attributes", fileName = "obj_att_")]
public class CharacterAttributes : ScriptableObject {
    private Attribute hp;
    private Attribute sp;
    private Attribute atk;
    private Attribute mag;
    private Attribute def;
    private Attribute waterRes, lightningRes, fireRes;
    private Attribute agi;
    private Attribute luk;

    private DamageType damageType;
}
